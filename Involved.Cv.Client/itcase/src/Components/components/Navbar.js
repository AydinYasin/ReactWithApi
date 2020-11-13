import React from 'react';
import { Nav, NavDropdown, Navbar, Form, FormControl, Button } from 'react-bootstrap';
import LogoPhoto from '../image/logoinvolved.png'
import { FaBeer, FaUser, FaUserPlus } from 'react-icons/fa';

function Navigationbar() {
    return (

        <Navbar bg="light" variant="light" sticky='top'>
            <Navbar.Brand href="#home">
                <img
                    src={LogoPhoto}
                    width="200"
                    height="40"
                    className="d-inline-block align-top"
                    alt="React Bootstrap logo"
                />
            </Navbar.Brand>
            <Nav className="mr-auto">
                <Nav.Link href="#home">Home</Nav.Link>
                <Nav.Link href="#features">Contact</Nav.Link>
                <Nav.Link href="#pricing">Over ons</Nav.Link>
            </Nav>

            <Button variant="success" style={{ margin: 10 }}><FaUser /> Inloggen</Button>
            <Button variant="info"><FaUserPlus /> Registreren</Button>

        </Navbar>

    )
}

export default Navigationbar; 