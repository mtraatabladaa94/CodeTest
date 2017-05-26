package com.teamsadara.encuesta.models.pojo;

/**
 * Created by Ing. Michel Roberto Traña Tablada(github.com/mtraatabladaa94) on 24/05/2017.
 */

import com.j256.ormlite.field.DatabaseField;
import com.j256.ormlite.table.DatabaseTable;

@DatabaseTable(tableName = "tblLCategories")
public class category {

    public static final String CATEGORY_ID = "categoryID";
    public static final String CATEGORY_NAME = "categoryName";



    @DatabaseField(generatedId = true, columnName = CATEGORY_ID)
    private int categoryID;
    public int getCategoryID() { return categoryID; }
    public void setCategoryID(int categoryID) {
        this.categoryID = categoryID;
    }

    @DatabaseField(columnName = CATEGORY_NAME)
    private String categoryName;
    public String getCategoryName() {
        return categoryName;
    }
    public void setCategoryName(String categoryName) {
        this.categoryName = categoryName;
    }

}
