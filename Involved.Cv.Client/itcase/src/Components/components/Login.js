import React from 'react';
import { } from 'react-bootstrap';
import { } from '@material-ui/core';
import {useTranslation } from 'react-i18next';
import { LinkContainer } from 'react-router-bootstrap'

const Login = () => {
    const { t, i18n } = useTranslation()
    return (
        <div class="wrapper">
            <div id="formContent">
                <div class="fadeIn first">
                    <h3 class="Login-h3">{t("welcome")}</h3>
                    <form>
                        <input type="text" id="login" name="login" placeholder="Email"></input>
                        <input type="text" id="password" name="login" placeholder={t("password")}></input>
                        <input type="submit" value={t("login")}></input>
                        <div id="formFooter">
                            <a id="Login-a" class="underlineHover" href="#">{t("reset")}</a><br></br>
                           <LinkContainer to="Register"><a href="components/Register.js" id="Register-a" class="underlineHover" href="#">{t("registerLink")}</a></LinkContainer>
                        </div>
                    </form>
                </div>
            </div>
        </div>
    )
}

export default Login; 