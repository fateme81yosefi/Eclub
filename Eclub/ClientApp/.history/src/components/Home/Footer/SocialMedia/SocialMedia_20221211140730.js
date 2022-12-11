import React from "react";
import "./SocialMedia.css"
export default function SocialMedia() {
  return (
    <div
      className="container"
      style={{
        display: "flex",
        alignItems: "center",
        justifyContent: "center",
        flexDirection: "column",
      }}
    >      <div className="containSocial">
        <span>:ما را در شبکه های اجتماعی دنبال کنید</span>
        <div className="containLogo">
          <img src="https://s2.uupload.ir/files/instagram_xovg.png" />
          <img src="https://s2.uupload.ir/files/telegram-icon_ysy5.png" />
        </div>
      </div>
    </div>
  );
}
