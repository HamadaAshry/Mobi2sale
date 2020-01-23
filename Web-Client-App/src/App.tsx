import React, { Component } from 'react';
import {connect} from 'react-redux';
import { BrowserRouter, Switch, Route } from 'react-router-dom';
import $ from 'jquery';



import SideBar from './Components/SideBar/SideBar';
import NavigationBar from './Components/Navbar/Navbar';
import BarChartDemo from './Components/AnalysisView/AnalysisView';
import CategoriesTable from './Components/CategoriesTable/CategoriesTable';
import SubCategoriesyTable from './Components/SubCategoriesTable/SubCategoriesTable';
import ItemsTable from './Components/ItemsTable/ItemsTable';





import './App.css';





interface AppProps {
  match?: any
};

interface AppState {
  showSideBar?: any,

}

class App extends Component <AppProps, AppState> {
  state = {
    showSideBar: true,
  }
  
  // Component Did UP Date Function
  componentDidUpdate() {
    const {showSideBar} = this.state;
    if (showSideBar === true) {
      document.getElementById('main-side')?.setAttribute('data-view-side', 'full-width');
      $('#app-body').addClass('full-width').removeClass('min-width');
    } else {
      document.getElementById('main-side')?.removeAttribute('data-view-side');
      $('#app-body').addClass('min-width').removeClass('full-width');
    }
  }
  // Component Did Mount Function 
  componentDidMount() {
    const {showSideBar} = this.state;
    if (showSideBar === true) {
      document.getElementById('main-side')?.setAttribute('data-view-side', 'full-width');
      $('#app-body').addClass('full-width').removeClass('min-width');
    } else {
      document.getElementById('main-side')?.removeAttribute('data-view-side');
      $('#app-body').addClass('min-width').removeClass('full-width');
    }
  }

  // Toggle SideBar Function
  toggleSideBar = () => {
    const {showSideBar} = this.state;
    this.setState({
      showSideBar: !showSideBar
    })
  }




  
  
  render() {
    return (
      <>
      <BrowserRouter>
        <div className='App' id='app-body'>
          <div className='row'>
              <SideBar showSideBar={this.state.showSideBar}  />
              <NavigationBar isShowSideBar={this.state.showSideBar} toggleFunctionSideBar={this.toggleSideBar} />
              <BarChartDemo />
              <Switch>
                <Route exact path='/main-Categories-table' component={CategoriesTable}  />
                <Route  path="/SubCategories/:ID" component={SubCategoriesyTable} />
                <Route  path="/ViewCategories/:SubCategoriesName/:ID"  component={ItemsTable}/>
                
              </Switch>
          </div>
        </div>
      </BrowserRouter>
      </>
      
    );
  };
}

function mapStateToProps (state:any) {
  return {
  }
}


function mapDispatchToProps (dispatch:any) {
  return{
  }
}


export default connect(mapStateToProps, mapDispatchToProps)(App);
