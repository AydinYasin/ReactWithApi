import React, { useState, useEffect } from 'react';
import { Col, Row, Container, ProgressBar, Button, DropdownButton, SplitButton, ButtonGroup, Dropdown, InputGroup, Form, type } from 'react-bootstrap';
import FilterEmployee from './filterEmployee';
import axios from 'axios'
import { Grid } from 'react-bootstrap'
import ReactPaginate from 'react-paginate';


const HomePage = () => {
     const [persons, setPersons] = useState([])
     const [currentPage, setCurrentPage] = useState(0);

     useEffect(() => {
          axios.get(process.env.REACT_APP_URL).then(res => {
               const persons = res.data;
               setPersons(persons);
          })
     }, [])

     const PER_PAGE = 4;
     const offset = currentPage * PER_PAGE;
     const currentPageData = persons.slice(offset, offset + PER_PAGE).map(person =>
          <Col xs={12} md={6} className="colPerson" >
               <Row className="row-person">
                    <Col xs={12} md={12} lg={6} className="dadadada" >
                         <Col style={{ display: "flex", justifyContent: "center" }}>
                              <img src='/profile.png' alt='Profile Image' style={{ width: 200, height: 200, display: "block" }} />
                         </Col>
                         <Col style={{ display: "flex", justifyContent: "center" }}>
                              <Button className="buttonProfile" variant="outline-success">Bezoek Profiel</Button>{' '}
                         </Col>
                    </Col>
                    <Col xs={12} md={12} lg={6}>
                         <h5 style={{ textAlign: "center", paddingTop: "10px" }}>Personal Information</h5>
                         <h6 style={{ textAlign: "left" }} >Name</h6>
                         <p style={{ textAlign: "left" }} ><b>{person.firstName} {person.lastName}</b></p>
                         <h6 style={{ textAlign: "left" }}>Location</h6>
                         <p style={{ textAlign: "left" }}>{person.township}</p>
                         <h6 style={{ textAlign: "left" }} >Email</h6>
                         <p style={{ textAlign: "left" }} >{person.email}</p>
                         <h6 style={{ textAlign: "left" }}>Keywords</h6>
                         <p style={{ textAlign: "left" }} >{person.skillOverviews.map(k => k.name + " ")}</p>
                    </Col>
               </Row>
          </Col>
     );

     const pageCount = Math.ceil(persons.length / PER_PAGE);
     console.log(persons.length)

     function handlePageClick({ selected: selectedPage }) {
          setCurrentPage(selectedPage);
     }

     return (
          <div >
               <FilterEmployee />

     <div style={{ width: "80%", margin: "auto" }} className="parentContainerFluis">
          <Container fluid className>
               {currentPageData}
               <ReactPaginate
                    previousLabel={"← Previous"}
                    nextLabel={"Next →"}
                    pageCount={pageCount}
                    onPageChange={handlePageClick}
                    containerClassName={"pagination"}
                    previousLinkClassName={"pagination__link"}
                    nextLinkClassName={"pagination__link"}
                    disabledClassName={"pagination__link--disabled"}
                    activeClassName={"pagination__link--active"}
                    className="PaginateHome"
               />
          </Container>

     </div>
          </div >

     );
}
export default HomePage;