import React from 'react';
import {} from 'react-bootstrap';
import { Link } from 'react-router-dom'
import IconInstagram from '../image/instagram.png'
import IconFacebook from '../image/facebook.png'
import IconTwitter from '../image/twitter.png'

const Footer = () => {
  return (

    <footer class="site-footer">
      <div class="container">
        <div class="row" id="row-footer">
          <div class="col-md-8 col-sm-6 col-xs-12">
            <p class="copyright-text">Copyright &copy; 2020 All Rights Reserved by Cronos
            </p>
          </div>

          <div class="col-md-4 col-sm-6 col-xs-12">
            <ul class="social-icons">
              <li><a class="instagram" href="#"><img src={IconInstagram} width="25" height="25"/><i class="fa fa-instagram"></i></a></li>
              <li><a class="twitter" href="#"><img src={IconFacebook} width="25" height="25"/><i class="fa fa-twitter"></i></a></li>
              <li><a class="twitter" href="#"><img src={IconTwitter} width="25" height="25"/><i class="fa fa-twitter"></i></a></li>
            </ul>
          </div>
        </div>
      </div>
</footer>
  )
}

export default Footer;