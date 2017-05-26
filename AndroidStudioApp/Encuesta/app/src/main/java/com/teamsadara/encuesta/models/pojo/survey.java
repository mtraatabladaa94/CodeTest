package com.teamsadara.encuesta.models.pojo;

/**
 * Created by Ing. Michel Roberto Traña Tablada(github.com/mtraatabladaa94) on 24/05/2017.
 */

import com.j256.ormlite.table.DatabaseTable;
import com.j256.ormlite.field.DatabaseField;
import java.util.Date;

@DatabaseTable(tableName = "tblSurveys")
public class survey {

    public static final String SURVEY_ID = "surveyID";
    public static final String CATEGORY = "category";
    public static final String SURVEY_DATE = "surveyDate";
    public static final String SURVEY_NAME = "surveyName";
    public static final String STARTED = "started";
    public static final String FAVORITE = "favorite";
    public static final String IS_ACTIVE = "isActive";

    @DatabaseField(columnName = SURVEY_ID)
    private String surveyID;
    public String getSurveyID() {
        return surveyID;
    }
    public void setSurveyID(String surveyID) {
        this.surveyID = surveyID;
    }

    @DatabaseField(columnName = CATEGORY, foreign = true)
    private category category;
    public category getCategory() {
        return category;
    }
    public void setCategory(category category) {
        this.category = category;
    }

    @DatabaseField(columnName = SURVEY_DATE)
    private Date surveyDate;
    public Date getSurveyDate() {
        return surveyDate;
    }
    public void setSurveyDate(Date surveyDate) {
        this.surveyDate = surveyDate;
    }

    @DatabaseField(columnName = SURVEY_NAME)
    private String surveyName;
    public String getSurveyName() {
        return surveyName;
    }
    public void setSurveyName(String surveyName) { this.surveyName = surveyName; }

    @DatabaseField(columnName = STARTED)
    private Integer started;
    public Integer getStarted() {
        return started;
    }
    public void setStarted(Integer started) {
        this.started = started;
    }

    @DatabaseField(columnName = FAVORITE)
    private boolean favorite;
    public boolean getFavorite() { return favorite; }
    public void setFavorite(boolean favorite) { this.favorite = favorite; }

    @DatabaseField(columnName = IS_ACTIVE)
    private Integer isActive;
    public Integer getIsActive() {
        return isActive;
    }
    public void setIsActive(Integer isActive) {
        this.isActive = isActive;
    }

}
