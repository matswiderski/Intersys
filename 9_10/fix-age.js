console.log(fixage([1, 3, 3, 2, 11, 6]));
function fixage(array) {
  let fixed = array.filter((item) => {
    if (item < 0 || item > 100) {
      throw "There are illegal elements in the array";
    }
    return 18 <= item && item <= 60;
  });
  return fixed.length > 0 ? fixed.toString() : "NA";
}
