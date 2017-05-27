package com.teamsadara.encuesta.views.survey;

import android.net.Uri;
import android.os.Bundle;
import android.support.v4.app.Fragment;
import android.support.v7.widget.LinearLayoutManager;
import android.support.v7.widget.RecyclerView;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.Toast;

import com.teamsadara.encuesta.R;

import com.teamsadara.encuesta.models.dataProvider.surveyDataProvider;

import java.util.ArrayList;

/**
 * A simple {@link Fragment} subclass.
 * Activities that contain this fragment must implement the
 * {@link listSurveyFragment.OnFragmentInteractionListener} interface
 * to handle interaction events.
 * Use the {@link listSurveyFragment#newInstance} factory method to
 * create an instance of this fragment.
 */
public class listSurveyFragment extends Fragment {
    android.support.v7.widget.RecyclerView recyclerView;
    RecyclerView.Adapter adapter;
    RecyclerView.LayoutManager layout;
    ArrayList<surveyDataProvider> arrayList = new ArrayList<surveyDataProvider>();

    // TODO: Rename parameter arguments, choose names that match
    // the fragment initialization parameters, e.g. ARG_ITEM_NUMBER
    private static final String ARG_PARAM1 = "param1";
    private static final String ARG_PARAM2 = "param2";

    // TODO: Rename and change types of parameters
    private String mParam1;
    private String mParam2;

    private OnFragmentInteractionListener mListener;

    public listSurveyFragment() {
        // Required empty public constructor
    }

    /**
     * Use this factory method to create a new instance of
     * this fragment using the provided parameters.
     *
     * @param param1 Parameter 1.
     * @param param2 Parameter 2.
     * @return A new instance of fragment listSurveyFragment.
     */
    // TODO: Rename and change types and number of parameters
    public static listSurveyFragment newInstance(String param1, String param2) {
        listSurveyFragment fragment = new listSurveyFragment();
        Bundle args = new Bundle();
        args.putString(ARG_PARAM1, param1);
        args.putString(ARG_PARAM2, param2);
        fragment.setArguments(args);
        return fragment;
    }

    @Override
    public void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        if (getArguments() != null) {
            mParam1 = getArguments().getString(ARG_PARAM1);
            mParam2 = getArguments().getString(ARG_PARAM2);
        }
    }

    @Override
    public View onCreateView(LayoutInflater inflater, ViewGroup container,
                             Bundle savedInstanceState) {
        // Inflate the layout for this fragment
        View view = inflater.inflate(R.layout.fragment_list_survey, container, false);

        //AQUI VA EL CODIGO DEL DISEÑO
        try {
            this.recyclerView = (RecyclerView)view.findViewById(R.id.rcvSurveyList);
            this.LoadData();
            Toast.makeText(this.getActivity(), "Hello Michael", Toast.LENGTH_LONG).show();
        }
        catch(Exception ex) {
            Toast.makeText(this.getActivity(), "Error: " + ex.getMessage(), Toast.LENGTH_LONG).show();
        }

        return view;
    }

    // TODO: Rename method, update argument and hook method into UI event
    public void onButtonPressed(Uri uri) {
        if (mListener != null) {
            mListener.onFragmentInteraction(uri);
        }
    }

    @Override
    public void onDetach() {
        super.onDetach();
        mListener = null;
    }

    /**
     * This interface must be implemented by activities that contain this
     * fragment to allow an interaction in this fragment to be communicated
     * to the activity and potentially other fragments contained in that
     * activity.
     * <p>
     * See the Android Training lesson <a href=
     * "http://developer.android.com/training/basics/fragments/communicating.html"
     * >Communicating with Other Fragments</a> for more information.
     */
    public interface OnFragmentInteractionListener {
        // TODO: Update argument type and name
        void onFragmentInteraction(Uri uri);
    }

    /*Customs Methods*/
    private void LoadData() {
        this.adapter = new surveyRecyclerAdapter(this.arrayList);
        this.recyclerView.setHasFixedSize(true);
        this.layout = new LinearLayoutManager(this.getActivity());
        recyclerView.setLayoutManager(this.layout);
        recyclerView.setAdapter(this.adapter);
    }
}
