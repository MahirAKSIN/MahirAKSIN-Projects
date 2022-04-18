import React, { useEffect, useState } from "react";

function EffectSample2() {
  const [sayac, setSayac] = useState(0);

  useEffect(() => {
    console.log("Sayac rendered");
  });

  useEffect(() => {
    console.log("Sayac changed");
  }, [sayac]);

  return (
    <div>
      <button onClick={()=>setSayac(sayac + 1)}>Artir</button>
      <br></br>
      <input type={"text"} placeholder={sayac}></input>
    </div>
  );
}

export default EffectSample2;
