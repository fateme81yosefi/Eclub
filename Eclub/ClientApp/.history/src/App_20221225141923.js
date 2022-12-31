import React, { Component, useEffect } from "react";
import Home from "./components/Home/Home";
import "./App.css";
import { BrowserRouter, Switch, Route } from "react-router-dom";

export default function App() {

useEffect(() => {GetData()}, [])

  const GetData = async () => {

    console.log('here')
    try {

      const body = {
        CompanyName: '-1'
      }

      const response = await fetch('Eclub/GetHomePageInfo', {
        method: 'POST',
        headers: {
          'Content-Type': 'application/json'
        }
      })

      if(!response.ok) throw new Error('nashod') 

      const result = await response.json()
      
      console.log('result = ', result)

      

    // fetch('controller/methodName', {
      // fetch('Eclub/GetHomePageInfo', {
      //   method: 'GET',
      //   headers: {
      //     'Content-Type': 'application/json'
      //   }
      // })
      // .then(response => response.json())
      // .then(result => {
      //   console.log('result = ', result)
      // })
    }
    catch(err) {
      console.log('err = ', err)
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
