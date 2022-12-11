import React from "react";
import Header from "./Header/Header";
import Platform from "./Platform/Platform";
import Access from "./Access/Access";
import Footer from "./Footer/Footer";

export default function Home (){

    return (
      <div className="container" style={{height:"200px",background:"red", display:"flex",alignItems:"center",justifyContent:"center",flexDirection:""}}>
      <Header/>
      <Platform/>
      <Access/>
      <Footer/>
      </div>
    );

}