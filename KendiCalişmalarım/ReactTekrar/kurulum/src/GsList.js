import React from "react";

function GsList(props) {
  const { product } = props;
  return (
    <div>
      <table>
        <tr>
          <td>id</td>
          <td>Name</td>
          <td>Unit Price</td>
        </tr>
        {product.map((item, key) => {
               if(item.unitPrice>40){
          return (
           
            <tr>
              <td>{item.id}</td>
              <td>{item.name}</td>
              <td>{item.unitPrice}</td>
            </tr>
          );
        }
        })}
      </table>
    </div>
  );
}

export default GsList;
