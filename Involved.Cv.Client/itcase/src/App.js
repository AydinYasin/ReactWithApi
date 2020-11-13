import React from 'react';
import './App.scss';
import { } from '@material-ui/core';
import { } from 'react-bootstrap';
import Home from './components/components/homePage';
import Navbar from './components/components/Navbar'
import Login from './components/components/Login';
import Contact from './components/components/contact';
import Register from './components/components/Register';
import Footer from './components/components/Footer';
import ChatBot from './components/chatbot/CustomChatbot';
import { Button } from 'react-bootstrap';
import { useTranslation } from 'react-i18next';
import { BrowserRouter as Router, Switch, Route } from 'react-router-dom';
import { } from 'react-bootstrap'


function App() {
  const { t, i18n } = useTranslation()

  const changeLanguage = (language) => {
    i18n.changeLanguage(language)
  }
  return (
    <div> 
      <Router> 
        
        <Navbar/>
        <Switch>
          <Route path="/" exact component={Home} />
          <Route path="/Register" component={Register} />
          <Route path="/Login" component={Login} />
          <Route path="/Contact" component={Contact} />
        </Switch>
      </Router>
      <ChatBot/>
      <Button onClick={() => changeLanguage("nl")}>NL</Button>
      <Button onClick={() => changeLanguage("en")}>EN</Button>
      <Button onClick={() => changeLanguage("fr")}>FR</Button>
      <Footer></Footer>
    </div>
  )
}


export default App;
