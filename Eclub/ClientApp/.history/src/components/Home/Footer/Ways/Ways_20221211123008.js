import React from "react";
import "./Ways.css"
export default function Ways() {
  return (
    <>
      <div className="containWays">
        <div className="col-xs-12 col-lg-3">
          <div className="picMainWay">
            <div className="picMainWay1">
              <img src="https://s2.uupload.ir/files/contact-us_ixtc.png" />
            </div>
          </div>
        </div>
        <div className="col-xs-12 col-lg-9">
          <div className="headOfWay">راه های ارتباطی ما</div>
          <div className="line">
            {" "}
            <span className="number">*6655*55#</span>
            <span className="dot">.................</span>
            <span className="name">USSD</span>
            <span className="imagewaylitt"><img src="https://s2.uupload.ir/files/mobile_r5q3.png"/></span>{" "}
          </div>

          <div className="line">
            {" "}
            <span className="number">02188240006</span>
            <span className="dot">.................</span>
            <span className="name">بخش فروش</span>
            <span className="imagewaylitt"><img src="https://s2.uupload.ir/files/foroosh_ty9u.png"/></span>{" "}
          </div>

          <div className="line">
            {" "}
            <span className="number">02188240007</span>
            <span className="dot">.................</span>
            <span className="name">بخش پشتیبانی</span>
            <span className="imagewaylitt"><img src="https://s2.uupload.ir/files/support_9afj.png"/></span>{" "}
          </div>
        </div>
      </div>
    </>
  );
}
