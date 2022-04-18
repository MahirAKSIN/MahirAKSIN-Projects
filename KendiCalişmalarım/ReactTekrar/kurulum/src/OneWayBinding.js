import React from "react";

function OneWayBinding() {
  let name = "Mahir";
  let surname = "Aksin";
  let year = 2022;

  const Method = {
    name: "Deniz",
    country: "Almanya",
  };

  return (
    <div className="w3-container text-center">
      <p>Name:{name}</p>
      <p>Surname:{surname}</p>
      <p>Year:{year}</p>
      <p>NameMethod:{Method.name}</p>
      <p>Country:{Method.country}</p>
    </div>
  );
}

export default OneWayBinding;
