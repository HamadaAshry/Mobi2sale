import React from 'react';
import { connect } from 'react-redux';
import {Button } from 'react-bootstrap';

import './Modal.css';

interface AppProps {

};

interface AppState {
    showModal?: any
};

const PopUpModal = (props: any) => {

    return (
        <div className='custom-popup' >
            <div className='modal-header' >
                <h4> edit {props.categoryName} </h4>
            </div>
            <div className='modal-body'>
                <div className='input'>
                    <i className='fa fa-th-large'> </i>
                    <input defaultValue={props.categoryName} />
                </div>
            </div>
            <div className='modal-footer'>
                <Button variant='danger' onClick={ () => props.CloseModal()} > close </Button>
                <Button variant='success' onClick={ () => props.CloseModal()} > save </Button>
            </div>
        </div>
    );
}


function mapStateToProps(state: any) {
    return {
        CategoryName: state.CategoryName
    }
}


export default connect(mapStateToProps)(PopUpModal)