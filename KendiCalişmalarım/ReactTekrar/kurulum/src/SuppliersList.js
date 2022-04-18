import React from "react";

function SuppliersList(props) {
  const { suppliers } = props;

  return (
    <div>
      <table>
        <tr>
          <td>id</td>
          <td>Name</td>
          <td>Price</td>
        </tr>
        {suppliers.map((item, key) => {
          return (
            <tr>
              <td>{item.id}</td>
              <td>{item.name}</td>
              <td>{item.unitPrice}</td>
            </tr>
          );
        })}
      </table>
    </div>
  );
}

export default SuppliersList;
