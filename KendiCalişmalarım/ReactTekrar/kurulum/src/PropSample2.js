import React from "react";

function PropSample2(props) {
  return (
    <div>
      <tr>Name:{props.name}</tr>
      <tr>
        <b>Surname:{props.surname}</b>
      </tr>
      <tr>Team:{props.team}</tr>
    </div>
  );
}
export default PropSample2;
