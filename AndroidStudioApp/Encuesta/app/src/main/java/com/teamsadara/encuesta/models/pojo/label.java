package com.teamsadara.encuesta.models.pojo;

/**
 * Created by Ing. Michel Roberto Traña Tablada(github.com/mtraatabladaa94) on 24/05/2017.
 */

import com.j256.ormlite.table.DatabaseTable;
import com.j256.ormlite.field.DatabaseField;

@DatabaseTable(tableName = "tblLabels")
public class label {

    public static final String LABEL_ID = "labelID";
    public static final String LABEL_NAME = "labelName";

    @DatabaseField(generatedId = true, columnName = LABEL_ID)
    private int labelID;
    public int getLabelID() {
        return labelID;
    }
    public void setLabelID(int labelID) {
        this.labelID = labelID;
    }

    @DatabaseField(columnName = LABEL_NAME)
    private String labelName;
    public String getLabelName() {
        return labelName;
    }
    public void setLabelName(String labelName) {
        this.labelName = labelName;
    }

}