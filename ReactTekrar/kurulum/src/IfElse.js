import React from "react";

function IfElse() {
  let onlineState = false;
  let onlineState1 = true;

  return (
    <div>
      {onlineState1 == true ? <h1>User Online</h1> : <h1>User Offline</h1>}
    </div>
  );
}

export default IfElse;
