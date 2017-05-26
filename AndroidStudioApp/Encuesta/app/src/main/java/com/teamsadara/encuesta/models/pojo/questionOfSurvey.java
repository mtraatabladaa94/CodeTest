package com.teamsadara.encuesta.models.pojo;

/**
 * Created by Ing. Michel Roberto Traña Tablada(github.com/mtraatabladaa94) on 24/05/2017.
 */

import com.j256.ormlite.field.DatabaseField;
import com.j256.ormlite.table.DatabaseTable;

@DatabaseTable(tableName = "tblQuestionsOfSurveys")
public class questionOfSurvey {

    public static final String QUESTION_ID = "questionID";
    public static final String QUESTION_KEY = "questionKey";
    public static final String QUESTION_NAME = "questionName";
    public static final String OPTION_MULTIPLE = "optionMultiple";
    public static final String QUANTITY_SELECTABLE = "quantitySelectable";
    public static final String OTHER_OPTION  = "otherOption";
    public static final String OTHER_VALUE = "otherValue";
    public static final String OBSERVATION_OPTION = "observationOption";
    public static final String OBSERVATION_VALUE = "observationValue";
    public static final String SURVEY = "survey";

    @DatabaseField(columnName = QUESTION_ID)
    private String questionID;
    public String getQuestionID() {
        return questionID;
    }
    public void setQuestionID(String questionID) {
        this.questionID = questionID;
    }

    @DatabaseField(columnName = QUESTION_KEY)
    private String questionKey;
    public String getQuestionKey() {
        return questionKey;
    }
    public void setQuestionKey(String questionKey) {
        this.questionKey = questionKey;
    }

    @DatabaseField(columnName = QUESTION_NAME)
    private String questionName;
    public String getQuestionName() {
        return questionName;
    }
    public void setQuestionName(String questionName) {
        this.questionName = questionName;
    }

    @DatabaseField(columnName = OPTION_MULTIPLE)
    private Integer optionMultiple;
    public Integer getOptionMultiple() {
        return optionMultiple;
    }
    public void setOptionMultiple(Integer optionMultiple) {
        this.optionMultiple = optionMultiple;
    }

    @DatabaseField(columnName = QUANTITY_SELECTABLE)
    private Integer quantitySelectable;
    public Integer getQuantitySelectable() {
        return quantitySelectable;
    }
    public void setQuantitySelectable(Integer quantitySelectable) { this.quantitySelectable = quantitySelectable; }

    @DatabaseField(columnName = OTHER_OPTION)
    private Integer otherOption;
    public Integer getOtherOption() {
        return otherOption;
    }
    public void setOtherOption(Integer otherOption) {
        this.otherOption = otherOption;
    }

    @DatabaseField(columnName = OTHER_VALUE)
    private String otherValue;
    public String getOtherValue() {
        return otherValue;
    }
    public void setOtherValue(String otherValue) {
        this.otherValue = otherValue;
    }

    @DatabaseField(columnName = OBSERVATION_OPTION)
    private Integer observationOption;
    public Integer getObservationOption() {
        return observationOption;
    }
    public void setObservationOption(Integer observationOption) { this.observationOption = observationOption; }

    @DatabaseField(columnName = OBSERVATION_VALUE)
    private String observationValue;
    public String getObservationValue() {
        return observationValue;
    }
    public void setObservationValue(String observationValue) { this.observationValue = observationValue; }

    @DatabaseField(columnName = SURVEY, foreign = true)
    private survey survey;
    public survey getSurvey() {
        return survey;
    }
    public void setSurvey(survey survey) { this.survey = survey; }

}
