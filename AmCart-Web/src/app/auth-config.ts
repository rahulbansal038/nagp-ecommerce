import {  AuthConfig } from "angular-oauth2-oidc";

export const authConfig: AuthConfig = {
    // Url of the Identity Provider
    issuer: "http://localhost:50541",

    // URL of the SPA to redirect the user to after login
    redirectUri: "http://localhost:4300/",

    // The SPA's id. The SPA is registerd with this id at the auth-server
    clientId: "mvc.client",

    // set the scope for the permissions the client should request
    // The first three are defined by OIDC. The 4th is a usecase-specific one
    scope: "openid profile"
 };