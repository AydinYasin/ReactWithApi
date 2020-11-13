import React from "react";
import ChatBot from "react-simple-chatbot";
import { ThemeProvider } from "styled-components";

function CustomChatbot(props) {  
    const config = {
        width: "300px",
        height: "400px",
        floating: true
      };

      const theme = {
        background: "white",
        fontFamily: "Arial, Helvetica, sans-serif",
        headerBgColor: "#00B2B2",
        headerFontColor: "#fff",
        headerFontSize: "25px",
        botBubbleColor: "#00B2B2",
        botFontColor: "#fff",
        userBubbleColor: "#fff",
        userFontColor: "#4c4c4c"
       };
    
    const steps = [
        {
            id: "Greet",
            message: "Hello, Welcome to our website",
            trigger: "Ask Name"
          },
          {
            id: "Ask Name",
            message: "Please type your name?",
            trigger: "Waiting user input for name"
          },
          {
            id: "Waiting user input for name",
            user: true,
            trigger: "Asking options to eat"
          },
          {
            id: "Asking options to eat",
            message: "Hi {previousValue}, Glad to know you !!",
            trigger: "Done"
          },
          {
            id: "Done",
            message: "Have a great day !!",
            end: true
          } 
    ];  
    return (
        <ThemeProvider theme={theme}>
           <ChatBot steps={steps} {...config} />
        </ThemeProvider>
       );

}   export default CustomChatbot;