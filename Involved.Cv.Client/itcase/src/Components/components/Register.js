import React from 'react';
import { } from 'react-bootstrap';
import { } from '@material-ui/core';
import {useTranslation } from 'react-i18next';
import { LinkContainer } from 'react-router-bootstrap'

const Register = () => {
    const { t, i18n } = useTranslation()
    return (
        <div class="wrapper fadeInDown">
            <div id="formContent">
                <div class="fadeIn first">

                    <h3 class="Register-h3">{t("welcome")}</h3>

                    <form>
                        <h4 class="Register-h4">{t("account")}</h4>
                        <input type="text" id="firstname" class="fadeIn second" name="firstname" placeholder={t("firstname")}></input>
                        <input type="text" id="lastname" class="fadeIn second" name="lastname" placeholder={t("name")}></input>
                        <input type="text" id="email" class="fadeIn second" name="email" placeholder="Email"></input>
                        <input type="text" id="password" class="fadeIn second" name="password" placeholder={t("password")}></input>
                        <input type="text" id="confirmPassword" class="fadeIn second" name="confirmPassworrd" placeholder={t("confirm")}></input>
                        <input type="submit" class="fadeIn third" value={t("register")}></input>

                        <div id="formFooter">
                            <a id="Login-a" class="underlineHover" href="#">{t("login")}</a>
                        </div>
                    </form>
                </div>
            </div>
        </div>
    )
}

export default Register; 