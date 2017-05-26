package com.teamsadara.encuesta;

import android.os.Bundle;

//import android.app.Fragment;
//import android.app.FragmentManager;
//import android.app.FragmentTransaction;

import android.support.v4.app.FragmentManager;
import android.support.v4.app.FragmentTransaction;
import android.support.v4.app.Fragment;
//import android.support.v4.app.FragmentActivity;

import android.support.design.widget.FloatingActionButton;
import android.support.design.widget.Snackbar;
import android.widget.Toast;
import android.view.View;
import android.support.design.widget.NavigationView;
import android.support.v4.view.GravityCompat;
import android.support.v4.widget.DrawerLayout;
import android.support.v7.app.ActionBarDrawerToggle;
import android.support.v7.app.AppCompatActivity;
import android.support.v7.widget.Toolbar;
import android.view.Menu;
import android.view.MenuItem;

import com.teamsadara.encuesta.views.category.listCategoryFragment;
import com.teamsadara.encuesta.views.survey.listSurveyFragment;

public class mainActivity extends AppCompatActivity
        implements NavigationView.OnNavigationItemSelectedListener {

    /*Section Declarations*/
    private FragmentManager _fragmentManager;
    private FragmentTransaction _fragmentTransaction;

    private listCategoryFragment _category;
    private listSurveyFragment _survey;
    /*End Section Declarations*/

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        Toolbar toolbar = (Toolbar) findViewById(R.id.toolbar);
        setSupportActionBar(toolbar);

        FloatingActionButton fab = (FloatingActionButton) findViewById(R.id.fab);
        fab.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Snackbar.make(view, "Replace with your own action", Snackbar.LENGTH_LONG)
                        .setAction("Action", null).show();
            }
        });

        DrawerLayout drawer = (DrawerLayout) findViewById(R.id.drawer_layout);
        ActionBarDrawerToggle toggle = new ActionBarDrawerToggle(
                this, drawer, toolbar, R.string.navigation_drawer_open, R.string.navigation_drawer_close);
        drawer.setDrawerListener(toggle);
        toggle.syncState();

        NavigationView navigationView = (NavigationView) findViewById(R.id.nav_view);
        navigationView.setNavigationItemSelectedListener(this);

        this.showFragmentSurvey();
    }

    @Override
    public void onBackPressed() {
        DrawerLayout drawer = (DrawerLayout) findViewById(R.id.drawer_layout);
        if (drawer.isDrawerOpen(GravityCompat.START)) {
            drawer.closeDrawer(GravityCompat.START);
        } else {
            super.onBackPressed();
        }
    }

    @Override
    public boolean onCreateOptionsMenu(Menu menu) {
        // Inflate the menu; this adds items to the action bar if it is present.
        getMenuInflater().inflate(R.menu.main, menu);
        return true;
    }

    @Override
    public boolean onOptionsItemSelected(MenuItem item) {
        // Handle action bar item clicks here. The action bar will
        // automatically handle clicks on the Home/Up button, so long
        // as you specify a parent activity in AndroidManifest.xml.
        int id = item.getItemId();

        //noinspection SimplifiableIfStatement
        if (id == R.id.action_settings) {
            return true;
        }

        return super.onOptionsItemSelected(item);
    }

    @SuppressWarnings("StatementWithEmptyBody")
    @Override
    public boolean onNavigationItemSelected(MenuItem item) {
        // Handle navigation view item clicks here.
        int id = item.getItemId();

        if (id == R.id.navCategory) {

            // Category action
            this.showFragmentCategory();

        } else if (id == R.id.navLabel) {

            // Label action


        } else if (id == R.id.navFavorite) {

            // Favorite action


        } else if (id == R.id.navSurvey) {

            // Survey action
            this.showFragmentSurvey();

        } else if (id == R.id.navShare) {

            // Share action


        } else if (id == R.id.navExport) {

            // Export action


        }

        DrawerLayout drawer = (DrawerLayout) findViewById(R.id.drawer_layout);
        drawer.closeDrawer(GravityCompat.START);
        return true;
    }

    /*Private Custom Action*/
    private void InitialFragmentManager() {
        this._fragmentManager = this.getSupportFragmentManager();
        this._fragmentTransaction = this._fragmentManager.beginTransaction();
    }

    private void PrepareFragment() {
        this.InitialFragmentManager();
        //Eliminando Fragmento de Categoria
        if(this._category != null) {
            this._fragmentTransaction.remove(this._category);
            this._category = null;
        }
        //Eliminando Fragmento de Encuesta
        if(this._survey != null) {
            this._fragmentTransaction.remove(this._survey);
            this._survey = null;
        }
    }

    private void showFragments(Fragment fragment) {
        this._fragmentTransaction.add(R.id.contentMain, (Fragment)fragment);
        this._fragmentTransaction.commit();
    }

    private void showFragmentCategory() {
        try {
            this.PrepareFragment();
            if(this._category == null) {
                this._category = new listCategoryFragment();
            }
            this.showFragments(this._category);
        }
        catch (Exception ex) {
            Toast.makeText(this, "Error al cargar categorias", Toast.LENGTH_LONG).show();
        }
    }
    private void showFragmentSurvey() {
        try {
            this.PrepareFragment();
            if(this._survey == null) {
                this._survey = new listSurveyFragment();
            }
            this.showFragments(this._survey);
        }
        catch (Exception ex) {
            Toast.makeText(this, "Error al cargar encuestas", Toast.LENGTH_LONG).show();
        }
    }
    /*End Custom Ation*/
}
