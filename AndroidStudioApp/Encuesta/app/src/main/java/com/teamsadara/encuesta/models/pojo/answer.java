package com.teamsadara.encuesta.models.pojo;

/**
 * Created by Ing. Michel Roberto Traña Tablada(github.com/mtraatabladaa94) on 24/05/2017.
 */

import com.j256.ormlite.field.DatabaseField;
import com.j256.ormlite.table.DatabaseTable;

@DatabaseTable(tableName = "tblAnswers")
public class answer {

    public static final String ANSWER_ID = "answerID";
    public static final String ANSWER_NAME = "answerName";
    public static final String QUESTION_OF_SURVEY = "question";

    @DatabaseField(columnName = ANSWER_ID, generatedId = true)
    private int answerID;
    public int getAnswerID() {
        return answerID;
    }
    public void setAnswerID(int answerID) {
        this.answerID = answerID;
    }

    @DatabaseField(columnName = ANSWER_NAME)
    private String answerName;
    public String getAnswerName() {
        return answerName;
    }
    public void setAnswerName(String answerName) {
        this.answerName = answerName;
    }

    @DatabaseField(columnName = QUESTION_OF_SURVEY, foreign = true)
    private questionOfSurvey questionOfSurvey;
    public questionOfSurvey getQuestion() {
        return questionOfSurvey;
    }
    public void setQuestion(questionOfSurvey question) {
        this.questionOfSurvey = question;
    }

}
