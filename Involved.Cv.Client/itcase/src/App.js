import React, { Component } from "react";
import './App.scss';
import { } from '@material-ui/core';
import { } from 'react-bootstrap';
//Componenets
import Home from './components/components/HomePage';
import Navbar from './components/components/Navbar';
import Login from './components/components/Login';
import Contact from './components/components/Contact';
import Register from './components/components/Register';
import Footer from './components/components/Footer';
import ChatBot from './components/chatbot/CustomChatbot';
import Profile from './components/components/Profile';
//Modules
import { Button } from 'react-bootstrap';
import { useTranslation } from 'react-i18next';
import { BrowserRouter as Router, Switch, Route, } from 'react-router-dom';
import { } from 'react-bootstrap'
import Auth from "./Auth/Auth";
import Callback from "./components/components/Callback";
import axios from 'axios';

class App extends Component {
  constructor(props) {
    super(props);
    this.auth = new Auth(this.props.history);
  }

  /*componentDidMount() {
    //Voorbeeld hoe data op te halen wanneer aangemeld

    axios.get("https://localhost:44323/All", { headers: { "Authorization": `Bearer ${localStorage.getItem('access_token')}` } })
      .then(res => {
        console.log(res.data);
      })
  }*/
  render() {
    return (

      <div>
        <Router>
          <Navbar auth={this.auth} />
          <Switch>
            <Route path="/" exact component={Home} />
            <Route path="/Register" component={Register} />
            <Route path="/Login" component={Login} />
            <Route path="/Contact" component={Contact} />
            <Route path="/Profile" component={Profile}/>
            <Route
              path="/callback"
              render={props => <Callback auth={this.auth} {...props} />}>
            </Route>

          </Switch>
        </Router>
        <ChatBot />
        <Footer></Footer>
      </div>
    )
  }
}

export default App;
