import React from 'react'
import {NavLink} from 'react-router-dom';
import './SideBar.css';
import {connect} from 'react-redux'

import Logo from './images/logo.png';

import $ from 'jquery';

interface AppProps {
    showSideBar?: any,
    Categories?: any
}

interface AppState {
}

class SideBar extends React.Component <AppProps , AppState> {
    
    componentDidMount() {
        $('.drop-down-control').click(function () {
            $(this).siblings('.dropdown-list').slideToggle();
            $(this).parent('li').siblings().find('.dropdown-list').slideUp()
            $(this).find('i.fa-chevron-right').toggleClass('open-dropdown');
            $(this).parent('li').siblings().find('i.fa-chevron-right').removeClass('open-dropdown')

        })
    }
    // Get Full Width Side Bar
    getFullWidthSideBar = () => {
        // const {Categories} = this.props;
        // const CategoriesList = Categories.map((categ:any, index:any) => {
        //     return(
        //         <li key={index}> <NavLink to={'/SubCategories/' + categ.CategoryName}> {categ.CategoryName} </NavLink> </li>
        //     )
        // })
        return(
            <>
                <div className='sidebar-logo' > 
                    <NavLink to='/'> <img className='logo-img' src={Logo} alt='Loog'/> </NavLink> 
                 </div>
                <ul data-side='full-width-side'>
                    <li> <NavLink to='/'><i className='fa fa-home'></i> home</NavLink> </li>
                    <li>
                        <NavLink className='drop-down-control' to='/main-Categories-table'  ><i className='fa fa-th-large'></i> categories <i className='fa fa-chevron-right'></i> </NavLink>
                        <ul className='dropdown-list'>
                            <li> <NavLink to='/'><i className='fa fa-mobile'></i> mobiles </NavLink> </li>
                            <li> <NavLink to='/'><i className='fa fa-plug'></i> accessories </NavLink> </li>
                        </ul>
                    </li>
                    <li>
                        <a className='drop-down-control' ><i className='fa fa-users'></i> suppliers <i className='fa fa-chevron-right'></i>  </a>
                        <ul className='dropdown-list'>
                            <li> <NavLink to='/'><i className='fa fa-money-check-alt'></i> accounting </NavLink> </li>
                            <li> <NavLink to='/'><i className='fa fa-list'></i> orders </NavLink> </li>
                        </ul>
                    </li>
                </ul>
            </>
        )
    }

    // Get Min Width Side Bar
    getMinWidthSideBar = () => {
        return(
            <>
                <div className='sidebar-logo'  > <NavLink to=''><img className='logo-img' src={Logo} alt='Loog'/></NavLink> </div>
                <ul data-side='min-width-side'>
                    <li> <NavLink to='/'><i className='fa fa-home'></i> <h6> home </h6>  </NavLink> </li>
                    <li className='show-list-items'>
                        <a className='' ><i className='fa fa-th-large'></i> <h6> categories </h6>   </a>

                    </li>
                    <li className='show-list-items'>
                        <a className='' ><i className='fa fa-users'></i> <h6> suppliers </h6>   </a>

                    </li>



                </ul>
            </>
        )
    }

    render() {
        return (
            <aside id='main-side' className='side-bar'>
                {this.props.showSideBar ? this.getFullWidthSideBar(): this.getMinWidthSideBar() }
            </aside>
        )
    }

}






function mapStateToProps(state: any) {
    return {
        CategoryName: state.CategoryName,
        Categories: state.Categories,
        subCategoryID: state.subCategoryID
        
    }
}


function mapDispatchToProps(dispatch: any) {
    return {

    }
}


export default connect(mapStateToProps, mapDispatchToProps)(SideBar);
