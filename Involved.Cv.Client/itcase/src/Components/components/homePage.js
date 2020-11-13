import React from 'react';
import { } from '@material-ui/core';
import { Col, Row, Container, ProgressBar, Button, DropdownButton, SplitButton, ButtonGroup, Dropdown, InputGroup, Form, type } from 'react-bootstrap';


function homePage (){
          return (

               <div>
                    <img src='/main.jpg' alt='Main Image' id="test1"></img>
                    <div>
                         <div>

                              <div className="mb-2">
                                   {[DropdownButton].map((DropdownType, idx) => (
                                        <DropdownType as={ButtonGroup} key={idx} id={`dropdown-button-drop-${idx}`} size="lg" title="Drop large" >
                                             <Form.Check aria-label="option 1" label=" Junior Developer" />
                                             <Form.Check aria-label="option 1" label=" Junior Developer" />
                                             <Form.Check aria-label="option 1" label=" Junior Developer" />
                                             <Form.Check aria-label="option 1" label=" Junior Developer" />
                                        </DropdownType>
                                   ))}
                              </div>

                         </div>





                         <div>
                              <Container>
                                   <Row xl className="row">
                                        <Col className='colom'>
                                             <Col>
                                                  <img src='/profil.jpg' alt='Profile Image' style={{ width: 250, height: 250 }} />
                                             </Col>
                                             <Col>
                                                  <Button className="buttonProfile" variant="outline-success">Bezoek Profiel</Button>{' '}
                                             </Col>
                                        </Col>

                                        <Col className='colom'>
                                             <h5>Personal Information</h5>
                                             <p><b>Selim Can Kaygun</b></p>
                                             <p>29/03/1998</p>
                                             <p>FRONT-END DEVELOPER</p>
                                             <p>Antwerpen, Belgium</p>
                                             <p>selimcan.kaygun@gmail.com</p>
                                        </Col>
                                        <Col className='colom'>
                                             <h5>About</h5>
                                             <p>"Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua."</p>
                                        </Col>
                                        <Col className='colom'>
                                             <h5>Skills</h5>
                                             <h6>talen</h6>
                                             <div>
                                                  <label>C#</label>
                                                  <ProgressBar variant="success" now={80} />

                                                  <label>JavaScript</label>
                                                  <ProgressBar variant="info" now={80} />

                                                  <label>Python</label>
                                                  <ProgressBar variant="warning" now={60} />

                                                  <label>Java</label>
                                                  <ProgressBar variant="danger" now={80} />
                                             </div>
                                        </Col>
                                   </Row>
                              </Container>
                         </div>
                         <div>
                              <Container>
                                   <Row xl className="row">
                                        <Col className='colom'>
                                             <Col>
                                                  <img src='/profil.jpg' style={{ width: 250, height: 250 }} />
                                             </Col>
                                             <Col>
                                                  <Button className="buttonProfile" variant="outline-success">Bezoek Profiel</Button>{' '}
                                             </Col>
                                        </Col>

                                        <Col className='colom'>
                                             <h5>Personal Information</h5>
                                             <p><b>Selim Can Kaygun</b></p>
                                             <p>29/03/1998</p>
                                             <p>FRONT-END DEVELOPER</p>
                                             <p>Antwerpen, Belgium</p>
                                             <p>selimcan.kaygun@gmail.com</p>
                                        </Col>
                                        <Col className='colom'>
                                             <h5>About</h5>
                                             <p>"Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua."</p>
                                        </Col>
                                        <Col className='colom'>
                                             <h5>Skills</h5>
                                             <h6>talen</h6>
                                             <div>
                                                  <label>C#</label>
                                                  <ProgressBar variant="success" now={80} />

                                                  <label>JavaScript</label>
                                                  <ProgressBar variant="info" now={80} />

                                                  <label>Python</label>
                                                  <ProgressBar variant="warning" now={60} />

                                                  <label>Java</label>
                                                  <ProgressBar variant="danger" now={80} />
                                             </div>
                                        </Col>
                                   </Row>
                              </Container>
                         </div>
                         <div>
                              <Container>
                                   <Row xl className="row">
                                        <Col className='colom'>
                                             <Col>
                                                  <img src='/profil.jpg' style={{ width: 250, height: 250 }} />
                                             </Col>
                                             <Col>
                                                  <Button className="buttonProfile" variant="outline-success">Bezoek Profiel</Button>{' '}
                                             </Col>
                                        </Col>

                                        <Col className='colom'>
                                             <h5>Personal Information</h5>
                                             <p><b>Selim Can Kaygun</b></p>
                                             <p>29/03/1998</p>
                                             <p>FRONT-END DEVELOPER</p>
                                             <p>Antwerpen, Belgium</p>
                                             <p>selimcan.kaygun@gmail.com</p>
                                        </Col>
                                        <Col className='colom'>
                                             <h5>About</h5>
                                             <p>"Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua."</p>
                                        </Col>
                                        <Col className='colom'>
                                             <h5>Skills</h5>
                                             <h6>talen</h6>
                                             <div>
                                                  <label>C#</label>
                                                  <ProgressBar variant="success" now={80} />

                                                  <label>JavaScript</label>
                                                  <ProgressBar variant="info" now={80} />

                                                  <label>Python</label>
                                                  <ProgressBar variant="warning" now={60} />

                                                  <label>Java</label>
                                                  <ProgressBar variant="danger" now={80} />
                                             </div>
                                        </Col>
                                   </Row>
                              </Container>
                         </div>

                    </div>


               </div>


          );

}
export default homePage;