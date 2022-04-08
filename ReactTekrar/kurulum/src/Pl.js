import React from "react";

function Pl(props) {
  const { supp } = props;

  return (
    <>
      <table>
        <tr>
          <td>id</td>
          <td>Name</td>
          <td>unitPrice</td>
        </tr>

        {
          
        supp.map((item, key) => {
          if (item.unitPrice < 10) {
            return (
              <tr>
                <td>{item.id}</td>
                <td>{item.name}</td>
                <td>{item.unitPrice}</td>
              </tr>
            );
          }
        })
        
        }

      </table>
    </>
  );
}

export default Pl;
