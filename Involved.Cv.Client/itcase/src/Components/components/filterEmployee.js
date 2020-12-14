import React from 'react';
import { Col, Row, Container, ProgressBar, Button, DropdownButton, SplitButton, ButtonGroup, Dropdown, InputGroup, Form, type } from 'react-bootstrap';
function FilterEmploye() {


    return (
        
        <div>

    <Container>
         <Row className="dropDownFilter">
             <Col className ="dropDownFilterColomn">
                <div className="mb-2">
                {[DropdownButton].map((DropdownType, idx) => (
                    <DropdownType className="buttonFocus" as={ButtonGroup} key={idx} id={`dropdown-button-drop-${idx}`} size="lg" title="Ervaring" >
                        <Form.Check aria-label="option 1" label=" Junior Developer" />
                        <Form.Check aria-label="option 2" label=" Medior Developer" />
                        <Form.Check aria-label="option 3" label=" Senior Developer" />
                    </DropdownType>
                ))}
                </div>
             </Col>
             <Col className ="dropDownFilterColomn">
             <div className="mb-2">
                {[DropdownButton].map((DropdownType, idx) => (
                    <DropdownType className="buttonFocus" as={ButtonGroup} key={idx} id={`dropdown-button-drop-${idx}`} size="lg" title="Technologie" >
                        <Form.Check aria-label="option 1" label=" C#" />
                        <Form.Check aria-label="option 1" label=" C++" />
                        <Form.Check aria-label="option 1" label=" C" />
                        <Form.Check aria-label="option 1" label=" JavaScript" />
                        <Form.Check aria-label="option 1" label=" Java" />
                        <Form.Check aria-label="option 1" label=" Python" />
                        <Form.Check aria-label="option 1" label=" PHP" />
                    </DropdownType>
                ))}
                </div>
             </Col>
             <Col className ="dropDownFilterColomn">
             <div className="mb-2">
                {[DropdownButton].map((DropdownType, idx) => (
                    <DropdownType className="buttonFocus" as={ButtonGroup} key={idx} id={`dropdown-button-drop-${idx}`} size="lg" title="Rol" >
                        <Form.Check aria-label="option 1" label=" Junior Developer" />
                        <Form.Check aria-label="option 1" label=" Junior Developer" />
                        <Form.Check aria-label="option 1" label=" Junior Developer" />
                        <Form.Check aria-label="option 1" label=" Junior Developer" />
                    </DropdownType>
                ))}
                </div></Col>
                <Col className ="dropDownFilterColomn">
             <div className="mb-2">
                {[DropdownButton].map((DropdownType, idx) => (
                    <DropdownType className="buttonFocus" as={ButtonGroup} key={idx} id={`dropdown-button-drop-${idx}`} size="lg" title="Beschikbaarheid" >
                        <Form.Check aria-label="option 1" label=" Junior Developer" />
                        <Form.Check aria-label="option 1" label=" Junior Developer" />
                        <Form.Check aria-label="option 1" label=" Junior Developer" />
                        <Form.Check aria-label="option 1" label=" Junior Developer" />
                    </DropdownType>
                ))}
                </div></Col>
         </Row>
     </Container>

   </div>

    )
}

export default FilterEmploye; 


