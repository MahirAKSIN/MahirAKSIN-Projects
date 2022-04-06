import React from "react";

function PropSample({ name, surname }) {
  return (
    <div>
      <tr>Name:{name}</tr>
      <tr>Surname:{surname}</tr>
    </div>
  );
}

export default PropSample;
