import React from "react";
import "./Footer.css";
import Ways from "./Ways/Ways";
import SocialMedia from "./SocialMedia/SocialMedia";

export default function Footer() {
  return (
    <div className="containFooter">
     <Ways />
      <SocialMedia />
    </div>
  );
}
