import React from 'react';
import emailjs from 'emailjs-com';

const Contact = () => {
//  const { t, i18n } = useTranslation()
  function sendEmail(e) {
    e.preventDefault();

    emailjs.sendForm(process.env.REACT_APP_SERVICEID, process.env.REACT_APP_TEMPLATEID, e.target, process.env.REACT_APP_USERID)
    .then((result) => {
      alert(result.text + " Mail sended successfully!");
  }, (error) => {
      alert(error.text + " Something went wrong!");
  });
    
  }


  return (
    <form id="form" class="form-group" onSubmit={sendEmail}>
    <div class="field">
      <label for="from_name">Name</label>
      <input class="form-control" type="text" name="from_name" id="from_name"/>
    </div>
    <div class="field">
      <label for="from_email">Email</label>
      <input class="form-control" type="text" name="from_email" id="from_email"/>
    </div>
    <div class="field">
      <label for="message">Message</label>
      <textarea class="form-control" type="text" name="message" id="message"/>
  </div>
    <input class="btn btn-primary" type="submit" id="button" value="Send Email"/>
  </form>
  );
}

export default Contact; 
