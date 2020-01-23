import React from 'react';
import { connect } from 'react-redux';
import { Table, Button, Container } from 'react-bootstrap';
import {NavLink} from 'react-router-dom';

import $ from 'jquery';

import DarkBackground from '../DarkBackground/Darkbackground';
import PopUpModal from '../Modal/Modal';

import Axios from 'axios';

interface AppProps {
    // Categories?: any,
    toggleModal?: any
    DomainName?: any
};

interface AppState {
    Modal?: boolean,
    Background?: boolean,
    CategoryName?: String,
    Categories?: any,
};
  
class CategoriesTable extends React.Component<AppProps, AppState> {
    state = {
        Modal: false,
        Background: false,
        CategoryName: "",
        Categories: [],
    }

    componentDidMount() {
        Axios.get(`${this.props.DomainName}/api/V1/Category`)
            .then(res => {
                this.setState({
                    Categories: res.data
                })
            })
            .catch(err => {
                console.log(err)
            })
    }
    
    
    
    
    toggleModal = (CategoryName:String) => {
        let {Modal} = this.state;
        let {Background} = this.state;
        this.setState({
            Background: !Background,
            Modal: !Modal,
            CategoryName: CategoryName
        })
        setTimeout(() => {
            $('.dark-background').addClass('dark-background-show')
        }, 100)
        setTimeout(() => {
            $('.custom-popup').addClass('custom-popup-show')
        }, 300)
    }

    CloseModal = () => {
        
        $('.custom-popup').removeClass('custom-popup-show')
      
        setTimeout(() => {
            $('.dark-background').removeClass('dark-background-show')
        }, 400)
        setTimeout(() => {
            this.setState({
                Background: false,
                Modal: false
            })
        }, 700)
      }
    
    
    
    
    
    render() {
        return (
            <>
                {this.state.Background ? <DarkBackground /> : null}
                {this.state.Modal ? <PopUpModal  CloseModal={this.CloseModal} categoryName={this.state.CategoryName} /> : null }
                <Container>
                    <div>
                        <Table striped bordered>
                            <thead>
                                <tr>
                                    <th>category</th>
                                    <th colSpan={2}> Actions </th>
                                </tr>
                            </thead>
                            <tbody>
                                {this.state.Categories.map((categ: any, index: number) => {
                                    return (
                                        <tr key={index}>
                                            <td>{categ.name}</td>
                                            <td> <NavLink  to={'/SubCategories/' + categ.id}>  <Button variant="outline-info" > <i className='fa fa-eye'></i> view sub category </Button> </NavLink> </td>
                                            <td><Button variant='outline-primary' onClick={() => this.toggleModal(categ.name)} > <i className='fa fa-edit'></i>  </Button></td>
                                        </tr>
                                    )
                                })}
                            </tbody>
                        </Table>
                    </div>
                </Container>
            </>
        );
    }
}


function mapStateToProps(state: any) {
    return {
        CategoryName: state.CategoryName,
        Categories: state.Categories,
        subCategoryID: state.subCategoryID,
        DomainName: state.DomainName
        
    }
}


function mapDispatchToProps(dispatch: any) {
    return {

    }
}


export default connect(mapStateToProps, mapDispatchToProps)(CategoriesTable);
