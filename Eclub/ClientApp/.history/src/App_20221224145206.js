import React, { Component } from "react";
import Home from "./components/Home/Home";
import "./App.css";
import { BrowserRouter, Switch, Route } from "react-router-dom";

export default function App() {

  const GetData = () => {

    fetch('controller/methodName')
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
