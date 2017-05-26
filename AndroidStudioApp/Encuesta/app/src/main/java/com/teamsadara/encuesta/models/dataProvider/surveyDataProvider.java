package com.teamsadara.encuesta.models.dataProvider;

/**
 * Created by Administrator on 26/05/2017.
 */

public class surveyDataProvider {
    private String surveyID;
    private String surveyCategory;
    private String surveyName;
    private String surveyDate;
    private String surveyHour;
    private int imageStarted;

    public surveyDataProvider(String _surveyID, String _surveyCategory, String _surveyName, String _surveyDate, String _surveyHour, int _imageStarted) {
        this.surveyID = _surveyID;
        this.surveyCategory = _surveyCategory;
        this.surveyName = _surveyName;
        this.surveyDate = _surveyDate;
        this.surveyHour = _surveyHour;
        this.imageStarted = _imageStarted;
    }

    public String getSurveyID() {
        return surveyID;
    }

    public void setSurveyID(String surveyID) {
        this.surveyID = surveyID;
    }

    public String getSurveyCategory() {
        return surveyCategory;
    }

    public void setSurveyCategory(String surveyCategory) {
        this.surveyCategory = surveyCategory;
    }

    public String getSurveyName() {
        return surveyName;
    }

    public void setSurveyName(String surveyName) {
        this.surveyName = surveyName;
    }

    public String getSurveyDate() {
        return surveyDate;
    }

    public void setSurveyDate(String surveyDate) {
        this.surveyDate = surveyDate;
    }

    public String getSurveyHour() {
        return surveyHour;
    }

    public void setSurveyHour(String surveyHour) {
        this.surveyHour = surveyHour;
    }

    public int getImageStarted() {
        return imageStarted;
    }

    public void setImageStarted(int imageStarted) {
        this.imageStarted = imageStarted;
    }
}
