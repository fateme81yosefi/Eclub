import React, { Component } from "react";
import Home from "./components/Home/Home";
import "./App.css";
import { BrowserRouter, Switch, Route } from "react-router-dom";

export default function App() {

  const GetData = () => {

    // fetch('controller/methodName', {
    fetch('Eclub/GetAgencysList', {
      method: 'GET',
      headers: {
        'Content-Type': 'application/json'
      }
    })
    .then(response => response.json())
    .then(result => {
      console.log('result = ', result)
    })
  }

  return (
    <BrowserRouter>
      <Switch>
        <Route exact path="/">
          <Home />
        </Route>
        <Route exact path="/parhamKish">
          <Home />
        </Route>
      </Switch>
    </BrowserRouter>
  );
}
