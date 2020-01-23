import React, { Ref } from 'react';
import { connect } from 'react-redux';
import { Table, Button, Container , Form , Image } from 'react-bootstrap';
import Axios from 'axios';
import {NavLink} from 'react-router-dom'; 

import './SubCategoriesTable.css';
import DarkBackground from '../DarkBackground/Darkbackground';
import PopUpModal from '../Modal/Modal';
import $ from 'jquery';


import ImageSource from './images/سنتر النور 1.jpg';




interface AppProps {
    match?: any,
    DomainName?: any
};

interface AppState {
    Data?: any,
    Modal?: boolean,
    Background?: boolean,
    CategoryName?: String
    name?: any,
    isEdit?: any,
    SelectCategories?: any,
    imgFile?: any,
    AddSubCategoryName?: String
};



  
class SubCategoriesyTable extends React.Component<AppProps, AppState> {

    
    
    state = {
        Data: {
            "data": [
              {

              }
            ],
          },
        Modal: false,
        Background: false,
        CategoryName: "",
        
        isEdit: true,
        SelectCategories: {},
        imgFile: '',
        AddSubCategoryName: ''
    }

    
    // Get Data From API When Component Did Mount

    // componentDidUpdate() {
    //     const handle = this.props.match.params;
    //     Axios.get(`${this.props.DomainName}/api/V1/Category/${handle.ID}`)
    //         .then(res => {
    //             this.setState({
    //                 SelectCategories: res.data
    //             })
    //         })
        
    // }
    
    
    
    componentDidMount() {
        const handle = this.props.match.params;
        
        Axios.post(`${this.props.DomainName}/api/V1/Subcategory/GetSubcategories/${handle.ID}`,
        {
            "pageNumber": 0,
            "pageSize": 0,
            "sortColumn": 0,
            "sortDirection": "string",
            "searchText": ""
          }
        
        )
            .then((response) => {
                this.setState({
                    Data: response.data,
                    
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

    toggleAdd = () => {
        let {isEdit} = this.state;

        this.setState({
            isEdit: !isEdit
        })

    }
    
    setImage = (event: React.ChangeEvent<HTMLInputElement>) => {

         let files = event.currentTarget.files?.[0];


         this.setState({
             imgFile: files
         })
         
         
        
        
    }

    changeName = (e: React.ChangeEvent<HTMLInputElement>) => {

        this.setState({
            AddSubCategoryName: e.target.value
        })

        console.log(this.state.AddSubCategoryName)
    }
    
    addSubCategoryFormModal = (e:any) => {
        let {SelectCategories} = this.state;
        const handle = this.props.match.params;

        return(
            <Form> 
                <Form.Group controlId="formBasicEmail">
                    <h4> add sub category on  </h4>
                    <Form.Label>Sub Category Name</Form.Label>
                    <Form.Control type="text" placeholder="Enter Name"  />
                </Form.Group>

                <Form.Group >
                    <Form.Label>image</Form.Label>
                    <Form.Control id='img' type="file" onChange={this.setImage} />
                </Form.Group>
                <Form.Group controlId="exampleForm.ControlSelect1">
                    <Form.Label>Category</Form.Label>
                    <Form.Control as="select">

                    <option value={handle.ID}> {handle.ID}</option>   


                    </Form.Control>
                </Form.Group>
                <Button variant="primary">
                    Submit
                </Button>
            </Form>
        )
    }

      
    render() {
        
        const handle = this.props.match.params;
        
        return (
            <>
                {this.state.Background ? <DarkBackground /> : null}
                {this.state.Modal ? <PopUpModal  CloseModal={this.CloseModal} categoryName={this.state.CategoryName} /> : null }
                <Container>
                    <div>
                        <Button variant='success' onClick={() => this.toggleAdd()} > add </Button>
                        <Table striped bordered>
                            <thead>
                                <tr>
                                    <th> name </th>
                                    <th colSpan={3}> Actions </th>
                                </tr>
                            </thead>
                            <tbody>
                                {this.state.Data.data.map((data: any, index: number) => {
                                    return (
                                        <>
                                        <tr key={index}>
                                            <td> <img className='subcategoryimg' src={`${this.props.DomainName}/${data.imageUrl}`} alt={data.imageUrl} /> </td>
                                            <td> {data.name} </td>
                                            <td> <NavLink to={`/ViewCategories/${handle.SubCategoriesName}/${index + 1}`}> <Button variant='outline-info'> <i className='fa fa-eye'></i> items </Button> </NavLink> </td>
                                            <td><Button variant='outline-primary' onClick={() => this.toggleModal(data.name)} > edit </Button></td>
                                            <td><Button variant="outline-danger"> <i className='fa fa-trash-alt'></i></Button></td>
                                        </tr>
                                        </>
                                    )
                                })}
                            </tbody>
                        </Table>
                        {this.state.isEdit ? this.addSubCategoryFormModal('') : null }
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
        DomainName: state.DomainName
    }
}


function mapDispatchToProps(dispatch: any) {
    return {
        EditMobile: () => dispatch({ type: 'EDITMOBILE' }),
        EditAccessories: () => dispatch({ type: 'EDITACCESSORIES' }),
    }
}


export default connect(mapStateToProps, mapDispatchToProps)(SubCategoriesyTable);
