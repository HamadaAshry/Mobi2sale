import React from 'react';
import { Navbar , Nav , Container  } from 'react-bootstrap';

import './Navbar.css';

const NavigationBar = (props: { isShowSideBar: any, toggleFunctionSideBar: any }) => {
    
    return (
        <Navbar   >
            <Container>
                <Nav.Link onClick={props.toggleFunctionSideBar} className='toggle-slide-icon'> <i className='fa fa-align-justify'></i> </Nav.Link>
                <Navbar.Toggle aria-controls="basic-navbar-nav" />
                <Navbar.Collapse id="basic-navbar-nav">
                    
                    <Nav className="ml-auto">
                    <Nav.Link href="#"> <i className='fa fa-search'></i> </Nav.Link>
                    <Nav.Link href="#"> <i className='fa fa-bell'></i> </Nav.Link>
                    <Nav.Link href="#"> <i className='fa fa-comments'></i> </Nav.Link>
                    <Nav.Link href="#"> <i className='fa fa-shopping-cart'></i>  </Nav.Link>

                    {/* <Nav.Link href="">  To Image </Nav.Link> */}
                    
                    </Nav>
                </Navbar.Collapse>
            </Container>
        </Navbar>
    )
}

export default NavigationBar