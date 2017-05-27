package com.teamsadara.encuesta.models.dataBase;

/**
 * Created by Ing. Michel Roberto Traña Tablada(github.com/mtraatabladaa94) on 25/05/2017.
 */


import android.content.Context;
import android.database.sqlite.SQLiteDatabase;

import com.j256.ormlite.android.apptools.OrmLiteSqliteOpenHelper;
import com.j256.ormlite.dao.Dao;
import com.j256.ormlite.support.ConnectionSource;
import com.j256.ormlite.table.TableUtils;

import com.teamsadara.encuesta.models.pojo.*;

import java.sql.SQLException;

public class ModelDb extends OrmLiteSqliteOpenHelper {

    private static final String DATABASE_NAME = "sadara_TeipeEncuestas.db";
    private static final int DATABASE_VERSION = 1;

    public ModelDb(Context context) {
        super(context, DATABASE_NAME, null, DATABASE_VERSION);
    }

    private Dao<category, Integer> categoryDao;
    private Dao<survey, Integer> surveyDao;
    private Dao<questionOfSurvey, Integer> questionOfSurveyDao;
    private Dao<answer, Integer> answerDao;
    private Dao<answerOfUser, Integer> answerOfUserDao;

    @Override
    public void close() {
        super.close();
        this.categoryDao = null;
        this.surveyDao = null;
        this.questionOfSurveyDao = null;
        this.answerDao = null;
        this.answerOfUserDao = null;
    }

    @Override
    public void onCreate(SQLiteDatabase sqLiteDatabase, ConnectionSource connectionSource) {
        try {
            TableUtils.createTable(connectionSource, category.class);
            TableUtils.createTable(connectionSource, survey.class);
            TableUtils.createTable(connectionSource, questionOfSurvey.class);
            TableUtils.createTable(connectionSource, answer.class);
            TableUtils.createTable(connectionSource, answerOfUser.class);
        }
        catch (SQLException e) {
            throw new RuntimeException(e);
        }
    }

    @Override
    public void onUpgrade(SQLiteDatabase sqLiteDatabase, ConnectionSource connectionSource, int i, int i1) {
        onCreate(sqLiteDatabase, connectionSource);
    }

    //Retornando listado de datos
    public Dao<category, Integer> getCategoryDao() throws SQLException {
        if(this.categoryDao == null) {
            this.categoryDao = this.getDao(category.class);
        }
        return categoryDao;
    }

    public Dao<survey, Integer> getSurveyDao() throws SQLException {
        if(this.surveyDao == null) {
            this.surveyDao = this.getDao(survey.class);
        }
        return surveyDao;
    }

    public Dao<questionOfSurvey, Integer> getQuestionOfSurveyDao() throws SQLException {
        if(this.questionOfSurveyDao == null) {
            this.questionOfSurveyDao = this.getDao(questionOfSurvey.class);
        }
        return questionOfSurveyDao;
    }

    public Dao<answer, Integer> getAnswerDao() throws SQLException {
        if(this.answerDao == null) {
            this.answerDao = this.getDao(answer.class);
        }
        return answerDao;
    }

    public Dao<answerOfUser, Integer> getAnswerOfUserDao() throws SQLException {
        if(this.answerOfUserDao == null) {
            this.answerOfUserDao = this.getDao(answerOfUser.class);
        }
        return answerOfUserDao;
    }
}
