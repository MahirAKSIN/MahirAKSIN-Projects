import React, { Component } from "react";
import Navbar from "./Navbar";

const Users = (props) => {
  return (
    <div>
      <Navbar title="User:Mahir">
        <div id="f"> </div>
      </Navbar>
      <lu>
        <li>Name:{props.name} </li>
        <li>Departmen:{props.departman}</li>
        <li>Maas:{props.maas}</li>
      </lu>
    </div>
  );
};
export default Users;
