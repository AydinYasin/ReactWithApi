import React, { Component } from 'react';
import { Nav, NavDropdown, Navbar, Form, FormControl, Button, Dropdown } from 'react-bootstrap';
import LogoPhoto from '../image/logoinvolved.png'
import { FaBeer, FaUser, FaUserPlus, FaGlobeEurope } from 'react-icons/fa';
import { Link } from 'react-router-dom'
import LoginButton from './LoginButton';
import LogoutButton from './LogoutButton';
import jwt_decode from "jwt-decode";


class Navigationbar extends Component {
    render() {
        {
            const accessToken = localStorage.getItem("access_token");
            var decoded;
            {accessToken ? decoded = jwt_decode(accessToken) : console.log("Nog niet ingelogd")};
        }
        const { isAuthenticated, login, logout } = this.props.auth;
        return (
            <Navbar collapseOnSelect expand="md" bg="light" variant="light" sticky='top'>
                <Navbar.Brand href="#home">
                    <Nav.Link>
                        <Link to='/'>
                            <img
                                src={LogoPhoto}
                                width="200"
                                height="40"
                                className="d-inline-block align-top"
                                alt="React Bootstrap logo"
                            />
                        </Link>
                    </Nav.Link>
                </Navbar.Brand>
                <Navbar.Toggle aria-controls="responsive-navbar-nav" />
                <Navbar.Collapse id="responsive-navbar-nav">
                    <Nav className="mr-auto">
                        <Nav.Item className="navBarItems">
                            <Nav.Link className="nav-link-home"><Link to='/'>Home</Link></Nav.Link>
                        </Nav.Item>
                        <Nav.Item>
                            <Nav.Link className="nav-link-contact" ><Link to='/Contact'>Contact</Link></Nav.Link>
                        </Nav.Item>
                        {
                            decoded && (Object.values(decoded)[0][0] == "Admin" &&
                            <Nav.Item>
                                <Nav.Link className="nav-link-home" ><Link to=''>Admin</Link></Nav.Link>
                            </Nav.Item>)
                        }
                        {
                            decoded && (Object.values(decoded)[0][0] == "Werknemer" &&
                            <Nav.Item>
                                <Nav.Link className="nav-link-home" ><Link to='/Profile'>Profiel</Link></Nav.Link>
                            </Nav.Item>)
                        }
                    </Nav>
                    <div style={{ marginTop: 10, display: "flex", justifyContent: "space-between" }}>
                        <Dropdown className="regis-login-lang-mobiel">
                            <Dropdown.Toggle variant="success" id="dropdown-basic">
                                <FaGlobeEurope size={15} />
                            </Dropdown.Toggle>

                            <Dropdown.Menu>
                                {/*<NavDropdown.Item onClick={() => changeLanguage("nl")} >NL</NavDropdown.Item>
                        <NavDropdown.Item onClick={() => changeLanguage("en")} >EN</NavDropdown.Item>
                        <NavDropdown.Item onClick={() => changeLanguage("fr")} >FR</NavDropdown.Item>*/}
                            </Dropdown.Menu>
                        </Dropdown>
                        <Button className="regis-login-lang-mobiel" variant="success" onClick={isAuthenticated() ? logout : login}> <FaUser />
                            {isAuthenticated() ? "Log Out" : "Log In"}
                        </Button>
                    </div>
                </Navbar.Collapse>
                <Dropdown className="regis-login-lang-desktop">
                    <Dropdown.Toggle variant="success" id="dropdown-basic">
                        <FaGlobeEurope size={15} />
                    </Dropdown.Toggle>

                    <Dropdown.Menu>
                        {/*<NavDropdown.Item onClick={() => changeLanguage("nl")} >NL</NavDropdown.Item>
                        <NavDropdown.Item onClick={() => changeLanguage("en")} >EN</NavDropdown.Item>
                <NavDropdown.Item onClick={() => changeLanguage("fr")} >FR</NavDropdown.Item>*/}
                    </Dropdown.Menu>
                </Dropdown>
                <Button className="regis-login-lang-desktop" variant="success" onClick={isAuthenticated() ? logout : login}> <FaUser />
                    {isAuthenticated() ? "Log Out" : "Log In"}
                </Button>
            </Navbar>
        )
    }
}

export default Navigationbar; 