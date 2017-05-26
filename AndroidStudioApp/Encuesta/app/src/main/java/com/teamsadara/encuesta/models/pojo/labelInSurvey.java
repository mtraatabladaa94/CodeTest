package com.teamsadara.encuesta.models.pojo;

/**
 * Created by Ing. Michel Roberto Traña Tablada(github.com/mtraatabladaa94) on 24/05/2017.
 */

import com.j256.ormlite.table.DatabaseTable;
import com.j256.ormlite.field.DatabaseField;

@DatabaseTable(tableName = "tblLabelsInSurveys")
public class labelInSurvey {

    public static final String LABEL_IN_SURVEY_ID = "labelInSurveyID";
    public static final String LABEL = "label";
    public static final String SURVEY = "SURVEY";

    @DatabaseField(columnName = LABEL_IN_SURVEY_ID, generatedId = true)
    private int labelInSurveyID;
    public int getLabelInSurveyID() { return labelInSurveyID; }
    public void setLabelInSurveyID(int labelInSurveyID) { this.labelInSurveyID = labelInSurveyID; }

    @DatabaseField(columnName = LABEL, foreign = true)
    private label label;
    public label getLabel() {
        return label;
    }
    public void setLabel(label label) {
        this.label = label;
    }

    @DatabaseField(columnName = SURVEY, foreign = true)
    private survey survey;
    public survey getSurvey() {
        return survey;
    }
    public void setSurvey(survey survey) {
        this.survey = survey;
    }

}
