import React from "react";

function PageMahirList(props) {
  const {suppM} =  props ;

  return (
    <div>
      <table>
        <tr>
          <td>id</td>
          <td>Name</td>
          <td>Unit Prices</td>
        </tr>
        {suppM.map((item, key) => {
            return(
          <tr>
            <td>{item.id}</td>
            <td>{item.name}</td>
            <td>{item.unitPrice}</td>
          </tr>
            );

        })}
        <tr></tr>
      </table>
    </div>
  );
}

export default PageMahirList;
