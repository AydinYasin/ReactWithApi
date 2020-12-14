import React from "react";
import { Form , FormGroup, Col} from 'react-bootstrap'
import DatePicker from './DatePicker'

const Profile = () => {

    return (
        <Form id="FormPadding">
            <div id="FormContainer">
        <Form.Group id="FormGroup">
            <Form.Label id="Label"><p>Email: Test@invovled.be</p></Form.Label>
            <Form.Control type="email" placeholder="Enter new email" />
        </Form.Group>
        <Form.Group>
            <Form.Label id="Label"><p>Firstname: Test</p></Form.Label>
            <Form.Control type="password" placeholder="Enter new Firstname" />
        </Form.Group>
        <Form.Group>
            <Form.Label id="Label"><p>Lastname: Test</p></Form.Label>
            <Form.Control type="email" placeholder="Enter new Lastname" />
        </Form.Group>
        <FormGroup>
        <Form.Label id="Label"><p>BirthDate: XX/XX/XXXX</p></Form.Label>
            <DatePicker></DatePicker>
        </FormGroup>
        <Form.Group controlId="formGroupPassword">
            <Form.Label id="Label"><p>Password</p></Form.Label>
            <Form.Control type="password" placeholder="Enter new password" />
        </Form.Group>
        <Form.Group>
        <Form.File id="formcheck-api-regular">
            <Form.File.Label id="Label"><p>Img input</p></Form.File.Label>
            <Form.File.Input id="Input"/>
        </Form.File>
        </Form.Group>
        </div>
        </Form>
    )
}

export default Profile
