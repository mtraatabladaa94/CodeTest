package com.teamsadara.encuesta.views.survey;

import android.support.v7.widget.RecyclerView;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.ImageView;
import android.widget.TextView;
import com.teamsadara.encuesta.R;

import java.util.ArrayList;

import com.teamsadara.encuesta.models.dataProvider.surveyDataProvider;

/**
 * Created by Administrator on 26/05/2017.
 */

public class surveyRecyclerAdapter extends RecyclerView.Adapter<surveyRecyclerAdapter.surveyRecyclerViewHolder> {

    private ArrayList<surveyDataProvider> arrayList = new ArrayList<surveyDataProvider>();

    public surveyRecyclerAdapter(ArrayList<surveyDataProvider> _arrayList) {
        this.arrayList = _arrayList;
    }

    @Override
    public surveyRecyclerViewHolder onCreateViewHolder(ViewGroup parent, int viewType) {
        View view = LayoutInflater.from(parent.getContext()).inflate(R.layout.recyclerview_survey, parent, false);
        surveyRecyclerViewHolder recyclerViewHolder = new surveyRecyclerViewHolder(view);
        return recyclerViewHolder;
    }

    @Override
    public void onBindViewHolder(surveyRecyclerViewHolder holder, int position) {
        surveyDataProvider dataProvider = this.arrayList.get(position);

        holder.imvStarted.setImageResource(dataProvider.getImageStarted());
        holder.txtSurveyCategory.setText(dataProvider.getSurveyCategory());
        holder.txtSurveyName.setText(dataProvider.getSurveyName());
        holder.txtDate.setText(dataProvider.getSurveyDate());
        holder.txtHour.setText(dataProvider.getSurveyHour());

    }

    @Override
    public int getItemCount() {
        return this.arrayList.size();
    }

    public static class surveyRecyclerViewHolder extends RecyclerView.ViewHolder {

        TextView txtSurveyCategory, txtSurveyName, txtDate, txtHour;
        ImageView imvStarted;

        public surveyRecyclerViewHolder(View view) {
            super(view);

            this.txtSurveyCategory = (TextView)view.findViewById(R.id.txtSurveyCategory);
            this.txtSurveyName = (TextView)view.findViewById(R.id.txtSurveyName);
            this.txtDate = (TextView)view.findViewById(R.id.txtDate);
            this.txtHour = (TextView)view.findViewById(R.id.txtHour);
            this.imvStarted = (ImageView)view.findViewById(R.id.imvStarted);

        }

    }

}
