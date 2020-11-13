import React from 'react';
import { } from '@material-ui/core';
import { } from 'react-bootstrap';

function Contact() {
        return (
            <div class="wrapper fadeInDown">
                <div id="formContent">

                    <div class="fadeIn first">
                        <h1>Contact</h1>
                    </div>

                    <form>
                        <input type="email" id="email" class="fadeIn second" name="email" placeholder="Email" required></input>
                        <input type="text" id="onderwerp" class="fadeIn third" name="onderwerp" placeholder="Onderwerp" required></input>
                        <textarea  placeholder="Vraag." class="fadeIn fourth" required></textarea>
                        <input type="submit" class="fadeIn fifth"></input>
                    </form>
                </div>
            </div>
        );
}

export default Contact;