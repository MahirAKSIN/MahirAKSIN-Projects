import React from "react";

function MetalBand() {
  const gunler = [
    "Pazartesi",
    "Sali",
    "Carsamba",
    "Persembe",
    "Cuma",
    "Camartesi",
    "Pazar",
  ];

  return (
    <div>
      {gunler.map((item, key) => {
        return (
          <li>
            {item}--{key}
          </li>
        );
      })}
    </div>
  );
}

export default MetalBand;
