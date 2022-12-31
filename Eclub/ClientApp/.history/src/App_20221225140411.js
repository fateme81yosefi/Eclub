import React, { Component, useEffect } from "react";
import Home from "./components/Home/Home";
import "./App.css";
import { BrowserRouter, Switch, Route } from "react-router-dom";

export default function App() {

useEffect(() => {GetData()}, [])

  const GetData = async () => {

    try {

      const response = await fetch('Eclub/GetHomePageInfo', {
        method: 'GET',
        headers: {
          'Content-Type': 'application/json'
        }
      })


      if(response.ok)

      const result = await response.json()
      
      

      

    // fetch('controller/methodName', {
      fetch('Eclub/GetHomePageInfo', {
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
    catch(err) {

    }
    finally {
      
    }

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
