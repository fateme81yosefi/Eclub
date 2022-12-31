import React, { Component, useEffect } from "react";
import Home from "./components/Home/Home";
import "./App.css";
import { BrowserRouter, Switch, Route } from "react-router-dom";
import { stringify } from "ajv";

export default function App() {

useEffect(() => {GetData()}, [])

  const GetData = async () => {

    console.log('here')
    try {

      const body = {
        CompanyName: 'ParhamKish'
      }

      // const response = await fetch('Eclub/Getter', {
      //   method: 'GET',
      //   headers: {
      //     'Content-Type': 'application/json'
      //   },
      // })

      const response = await fetch('EC/GetHomePageInfo', {
        method: 'POST',
        headers: {
          'Content-Type': 'application/json'
        },
        body: JSON.stringify(body)
      })

      console.log('response = ', response)
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
