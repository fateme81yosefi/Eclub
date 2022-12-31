import React, { Component } from 'react';
import Home from './components/Home/Home';
import "./App.css";
import { BrowserRouter } from 'react-router-dom';


export default function App () {

    return (
      <BrowserRouter></BrowserRouter>
      <Switch>
      <Home/>
   </Switch>
    );
}
