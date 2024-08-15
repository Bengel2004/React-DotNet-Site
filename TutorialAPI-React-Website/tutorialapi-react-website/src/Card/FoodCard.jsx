import style from './card.module.css'
import PropTypes from 'prop-types'


function FoodCard(props){

   let count = 0;
   const HandleClick = () => {count++; console.log({count})};
   
   const itemList = props.items;
   
   
   const listItem = itemList.map(item => 
      
   
      <div key={item.id} className={style.card} >
         <img className={style.cardimage} src={item.picture} alt="Profile picture"></img>
         <h2>{item.name}</h2>
         <p>{item.description} and {count}</p>
         <button onClick={() => HandleClick()}>View!</button>
      </div>
);

   // const title = props.name;
    return(
      <div>{listItem}</div>
    );
}


FoodCard.propTypes = {
   items: PropTypes.arrayOf(PropTypes.shape({id: PropTypes.number, name: PropTypes.string, description: PropTypes.string, picture: PropTypes.string}))
  }

FoodCard.defaultProps = {
   items: [],
}

export default FoodCard;