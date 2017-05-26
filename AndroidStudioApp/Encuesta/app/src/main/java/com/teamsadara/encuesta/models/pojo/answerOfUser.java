package com.teamsadara.encuesta.models.pojo;

/**
 * Created by Ing. Michel Roberto Traña Tablada(github.com/mtraatabladaa94) on 24/05/2017.
 */

import com.j256.ormlite.field.DatabaseField;
import com.j256.ormlite.table.DatabaseTable;

@DatabaseTable(tableName = "tblAnswersOfUsers")
public class answerOfUser {

    public static final String ANSWER_OF_USER_ID = "answerOfUserID";
    public static final String ANSWER_GROUP = "answerGroup";
    public static final String ANSWER_VALUE = "answerValue";
    public static final String ANSWER = "answer";

    @DatabaseField(columnName = ANSWER_OF_USER_ID)
    private int answerOfUserID;
    public int getAnswerOfUserID() { return answerOfUserID; }
    public void setAnswerOfUserID(int answerOfUserID) { this.answerOfUserID = answerOfUserID; }

    @DatabaseField(columnName = ANSWER_GROUP)
    private String answerGroup;
    public String getAnswerGroup() { return answerGroup; }
    public void setAnswerGroup(String answerGroup) { this.answerGroup = answerGroup; }

    @DatabaseField(columnName = ANSWER_VALUE)
    private Boolean answerValue;
    public Boolean getAnswerValue() { return answerValue; }
    public void setAnswerValue(Boolean answerValue) { this.answerValue = answerValue; }

    @DatabaseField(columnName = ANSWER, foreign = true)
    private answer answer;
    public com.teamsadara.encuesta.models.pojo.answer getAnswer() { return answer; }
    public void setAnswer(com.teamsadara.encuesta.models.pojo.answer answer) { this.answer = answer; }

}
