import React from 'react';
import { connect } from 'react-redux';
import { Table, Button, Container } from 'react-bootstrap';
import Axiso from 'axios';




interface AppProps {
    match?: any,
};

interface AppState {
    Data?: any,
    country?: any,
    state?: boolean
};




  
class ItemsTable extends React.Component<AppProps, AppState> {
    state = {
        Data: {
            "id": 0,
            "name": "",
            "username": "",
            "email": "",
            "company": {
                "name": "",
                "catchPhrase": "",
                "bs": ""
            }
        }
        ,
        country: {
            name: 'syria',
            capital: 'damas'
        },
        state: false
    }

    // Get Data From API When Component UpDate
    componentDidUpdate() {
        const handle = this.props.match.params;
        
        Axiso.get(`https://jsonplaceholder.typicode.com/${handle.SubCategoriesName}/${handle.ID}`)
            .then((response) => {
                this.setState({
                    Data: response.data,
                    state: true
                })
            })
    }
    
    // Get Data From API When Component Did Mount
    componentDidMount() {
        const handle = this.props.match.params;
        Axiso.get(`https://jsonplaceholder.typicode.com/${handle.SubCategoriesName}/${handle.ID}`)
            .then((response) => {
                this.setState({
                    Data: response.data,
                    state: true
                })
            })
    }
    
    
    render() {

        // const handle = this.props.match.params;
        // const {Data} = this.state;
        // const DataList = Data.map((data: any, index: number) => {
        //     return (
        //         <>
        //         <tr key={index}>
        //             <td></td>
        //             <td> Item  ID :  {data.id}</td>
        //             <td> Item Name :  {data.id}</td>
        //             <td></td>
        //             <td>
        //             <Button variant='primary' > edit </Button>
                        
        //             </td>
        //             <td><Button variant="success"> <i className='fa fa-plus-square'></i> add</Button></td>
        //         </tr>
        //         </>
        //     )
        // })
        
        return (
            <>
                <Container>
                    <div>
                        <Table striped bordered>
                            <thead>
                                <tr>
                                    <th> name </th>
                                    <th> username </th>
                                    <th> email </th>
                                    <th colSpan={2}> Actions </th>
                                </tr>
                            </thead>
                            <tbody>

                                <tr >
                                 <td> {this.state.Data.name} </td>
                                <td> {this.state.Data.username}</td>
                                 <td> {this.state.Data.email}  </td>
                                 <td>
                                    <Button variant='outline-primary' > <i className='fa fa-edit'></i> </Button>
                                    </td>
                                 <td><Button variant="outline-danger"> <i className='fa fa-trash-alt'></i></Button></td>
                                </tr>

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
    }
}


function mapDispatchToProps(dispatch: any) {
    return {
        EditMobile: () => dispatch({ type: 'EDITMOBILE' }),
        EditAccessories: () => dispatch({ type: 'EDITACCESSORIES' }),
    }
}


export default connect(mapStateToProps, mapDispatchToProps)(ItemsTable);
