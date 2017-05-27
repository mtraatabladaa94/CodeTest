package com.teamsadara.encuesta.controllers;

/**
 * Created by Administrator on 27/05/2017.
 */

import android.content.Context;

import com.j256.ormlite.android.apptools.OpenHelperManager;
import com.j256.ormlite.dao.Dao;
import com.teamsadara.encuesta.models.pojo.survey;
import com.teamsadara.encuesta.models.dataBase.ModelDb;
import com.teamsadara.encuesta.models.dataProvider.surveyDataProvider;

import java.sql.SQLException;
import java.text.DateFormat;
import java.text.SimpleDateFormat;
import java.util.ArrayList;
import java.util.List;

public class surveyController {

    ModelDb db;

    public surveyController(Context context) {
        this.db = OpenHelperManager.getHelper(context, ModelDb.class);
    }

    public ArrayList<surveyDataProvider> getSurveysMin() throws SQLException {
        ArrayList<surveyDataProvider> surveyList = new ArrayList<surveyDataProvider>();

        Dao dao;

        dao = this.db.getSurveyDao();
        List<survey> surveys = dao.queryForAll();

        //variables para formato de fecha
        DateFormat hourFormat = new SimpleDateFormat("");
        DateFormat dateFormat = new SimpleDateFormat("");
        //ciclo de llenado de DataProviders
        for(survey item : surveys) {
            surveyDataProvider objSurvey = new surveyDataProvider(
                item.getSurveyID(),
                item.getCategory().getCategoryName(),
                item.getSurveyName(),
                dateFormat.format(item.getSurveyDate()),
                hourFormat.format(item.getSurveyDate()),
                1
            );
            surveyList.add(objSurvey);
        }

        return surveyList;
    }

    public void onDestroy() {
        if(this.db != null) {
            OpenHelperManager.releaseHelper();
            this.db = null;
        }
    }

}
