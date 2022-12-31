import React, { Component } from "react";
import Home from "./components/Home/Home";
import "./App.css";
import { BrowserRouter, Switch, Route } from "react-router-dom";

export default function App() {
  return (
    <BrowserRouter>
      <Switch>
        <Route exact path="/pa">
          <Home />
        </Route>
      </Switch>
    </BrowserRouter>
  );
}
