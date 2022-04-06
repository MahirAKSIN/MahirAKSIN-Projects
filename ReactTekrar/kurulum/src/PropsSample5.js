import React from "react";

function PropsSample5(props) {
  return (
    <div>
      <button onClick={() => props.hello()}>Click</button>
    </div>
  );
}

export default PropsSample5;
