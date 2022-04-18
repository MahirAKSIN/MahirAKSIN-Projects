import React from "react";

function PropSample3(props) {
  return (
    <div>
      <tr>Name:{props.product.name}</tr>
      <tr>Surname:{props.product.surname}</tr>
    </div>
  );
}

export default PropSample3;
