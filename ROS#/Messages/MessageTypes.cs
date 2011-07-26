using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.InteropServices;

using Messages;
using Messages.std_msgs;
using Messages.geometry_msgs;
using Messages.nav_msgs;

namespace Messages
{
	public static class TypeHelper
	{
		public static Dictionary<MsgTypes, TypeInfo> TypeInformation = new Dictionary<MsgTypes, TypeInfo>()
		{			{MsgTypes.custom_msgs__arraytest, new TypeInfo(MsgTypes.custom_msgs__arraytest, false, 
@"int32[2] integers
int32[] lengthlessintegers",
				 new Dictionary<string, MsgFieldInfo>{
					{"integers", new MsgFieldInfo("integers", true, typeof(int), false, "", true, "2", false)},
					{"lengthlessintegers", new MsgFieldInfo("lengthlessintegers", true, typeof(int), false, "", true, "", false)}
			})},
			{MsgTypes.geometry_msgs__Point, new TypeInfo(MsgTypes.geometry_msgs__Point, false, 
@"float64 x
float64 y
float64 z",
				 new Dictionary<string, MsgFieldInfo>{
					{"x", new MsgFieldInfo("x", true, typeof(double), false, "", false, "", false)},
					{"y", new MsgFieldInfo("y", true, typeof(double), false, "", false, "", false)},
					{"z", new MsgFieldInfo("z", true, typeof(double), false, "", false, "", false)}
			})},
			{MsgTypes.geometry_msgs__Point32, new TypeInfo(MsgTypes.geometry_msgs__Point32, false, 
@"float32 x
float32 y
float32 z",
				 new Dictionary<string, MsgFieldInfo>{
					{"x", new MsgFieldInfo("x", true, typeof(double), false, "", false, "", false)},
					{"y", new MsgFieldInfo("y", true, typeof(double), false, "", false, "", false)},
					{"z", new MsgFieldInfo("z", true, typeof(double), false, "", false, "", false)}
			})},
			{MsgTypes.geometry_msgs__PointStamped, new TypeInfo(MsgTypes.geometry_msgs__PointStamped, true, 
@"Header header
Point point",
				 new Dictionary<string, MsgFieldInfo>{
					{"header", new MsgFieldInfo("header", false, typeof(TypedMessage<Header>), false, "", false, "", true)},
					{"point", new MsgFieldInfo("point", false, typeof(TypedMessage<Point>), false, "", false, "", true)}
			})},
			{MsgTypes.geometry_msgs__Polygon, new TypeInfo(MsgTypes.geometry_msgs__Polygon, true, 
@"geometry_msgs/Point32[] points",
				 new Dictionary<string, MsgFieldInfo>{
					{"points", new MsgFieldInfo("points", false, typeof(TypedMessage<Point32>), false, "", true, "", true)}
			})},
			{MsgTypes.geometry_msgs__PolygonStamped, new TypeInfo(MsgTypes.geometry_msgs__PolygonStamped, true, 
@"Header header
Polygon polygon",
				 new Dictionary<string, MsgFieldInfo>{
					{"header", new MsgFieldInfo("header", false, typeof(TypedMessage<Header>), false, "", false, "", true)},
					{"polygon", new MsgFieldInfo("polygon", false, typeof(TypedMessage<Polygon>), false, "", false, "", true)}
			})},
			{MsgTypes.geometry_msgs__Pose, new TypeInfo(MsgTypes.geometry_msgs__Pose, true, 
@"Point position
Quaternion orientation",
				 new Dictionary<string, MsgFieldInfo>{
					{"position", new MsgFieldInfo("position", false, typeof(TypedMessage<Point>), false, "", false, "", true)},
					{"orientation", new MsgFieldInfo("orientation", false, typeof(TypedMessage<Quaternion>), false, "", false, "", true)}
			})},
			{MsgTypes.geometry_msgs__Pose2D, new TypeInfo(MsgTypes.geometry_msgs__Pose2D, false, 
@"float64 x
float64 y
float64 theta",
				 new Dictionary<string, MsgFieldInfo>{
					{"x", new MsgFieldInfo("x", true, typeof(double), false, "", false, "", false)},
					{"y", new MsgFieldInfo("y", true, typeof(double), false, "", false, "", false)},
					{"theta", new MsgFieldInfo("theta", true, typeof(double), false, "", false, "", false)}
			})},
			{MsgTypes.geometry_msgs__PoseArray, new TypeInfo(MsgTypes.geometry_msgs__PoseArray, true, 
@"Header header
geometry_msgs/Pose[] poses",
				 new Dictionary<string, MsgFieldInfo>{
					{"header", new MsgFieldInfo("header", false, typeof(TypedMessage<Header>), false, "", false, "", true)},
					{"poses", new MsgFieldInfo("poses", false, typeof(TypedMessage<Pose>), false, "", true, "", true)}
			})},
			{MsgTypes.geometry_msgs__PoseStamped, new TypeInfo(MsgTypes.geometry_msgs__PoseStamped, true, 
@"Header header
Pose pose",
				 new Dictionary<string, MsgFieldInfo>{
					{"header", new MsgFieldInfo("header", false, typeof(TypedMessage<Header>), false, "", false, "", true)},
					{"pose", new MsgFieldInfo("pose", false, typeof(TypedMessage<Pose>), false, "", false, "", true)}
			})},
			{MsgTypes.geometry_msgs__PoseWithCovariance, new TypeInfo(MsgTypes.geometry_msgs__PoseWithCovariance, true, 
@"Pose pose
float64[36] covariance",
				 new Dictionary<string, MsgFieldInfo>{
					{"pose", new MsgFieldInfo("pose", false, typeof(TypedMessage<Pose>), false, "", false, "", true)},
					{"covariance", new MsgFieldInfo("covariance", true, typeof(double), false, "", true, "36", false)}
			})},
			{MsgTypes.geometry_msgs__PoseWithCovarianceStamped, new TypeInfo(MsgTypes.geometry_msgs__PoseWithCovarianceStamped, true, 
@"Header header
PoseWithCovariance pose",
				 new Dictionary<string, MsgFieldInfo>{
					{"header", new MsgFieldInfo("header", false, typeof(TypedMessage<Header>), false, "", false, "", true)},
					{"pose", new MsgFieldInfo("pose", false, typeof(TypedMessage<PoseWithCovariance>), false, "", false, "", true)}
			})},
			{MsgTypes.geometry_msgs__Quaternion, new TypeInfo(MsgTypes.geometry_msgs__Quaternion, false, 
@"float64 x
float64 y
float64 z
float64 w",
				 new Dictionary<string, MsgFieldInfo>{
					{"x", new MsgFieldInfo("x", true, typeof(double), false, "", false, "", false)},
					{"y", new MsgFieldInfo("y", true, typeof(double), false, "", false, "", false)},
					{"z", new MsgFieldInfo("z", true, typeof(double), false, "", false, "", false)},
					{"w", new MsgFieldInfo("w", true, typeof(double), false, "", false, "", false)}
			})},
			{MsgTypes.geometry_msgs__QuaternionStamped, new TypeInfo(MsgTypes.geometry_msgs__QuaternionStamped, true, 
@"Header header
Quaternion quaternion",
				 new Dictionary<string, MsgFieldInfo>{
					{"header", new MsgFieldInfo("header", false, typeof(TypedMessage<Header>), false, "", false, "", true)},
					{"quaternion", new MsgFieldInfo("quaternion", false, typeof(TypedMessage<Quaternion>), false, "", false, "", true)}
			})},
			{MsgTypes.geometry_msgs__Transform, new TypeInfo(MsgTypes.geometry_msgs__Transform, true, 
@"Vector3 translation
Quaternion rotation",
				 new Dictionary<string, MsgFieldInfo>{
					{"translation", new MsgFieldInfo("translation", false, typeof(TypedMessage<Vector3>), false, "", false, "", true)},
					{"rotation", new MsgFieldInfo("rotation", false, typeof(TypedMessage<Quaternion>), false, "", false, "", true)}
			})},
			{MsgTypes.geometry_msgs__TransformStamped, new TypeInfo(MsgTypes.geometry_msgs__TransformStamped, true, 
@"Header header
string child_frame_id
Transform transform",
				 new Dictionary<string, MsgFieldInfo>{
					{"header", new MsgFieldInfo("header", false, typeof(TypedMessage<Header>), false, "", false, "", true)},
					{"child_frame_id", new MsgFieldInfo("child_frame_id", true, typeof(string), false, "", false, "", false)},
					{"transform", new MsgFieldInfo("transform", false, typeof(TypedMessage<Transform>), false, "", false, "", true)}
			})},
			{MsgTypes.geometry_msgs__Twist, new TypeInfo(MsgTypes.geometry_msgs__Twist, true, 
@"Vector3  linear
Vector3  angular",
				 new Dictionary<string, MsgFieldInfo>{
					{"linear", new MsgFieldInfo("linear", false, typeof(TypedMessage<Vector3>), false, "", false, "", true)},
					{"angular", new MsgFieldInfo("angular", false, typeof(TypedMessage<Vector3>), false, "", false, "", true)}
			})},
			{MsgTypes.geometry_msgs__TwistStamped, new TypeInfo(MsgTypes.geometry_msgs__TwistStamped, true, 
@"Header header
Twist twist",
				 new Dictionary<string, MsgFieldInfo>{
					{"header", new MsgFieldInfo("header", false, typeof(TypedMessage<Header>), false, "", false, "", true)},
					{"twist", new MsgFieldInfo("twist", false, typeof(TypedMessage<Twist>), false, "", false, "", true)}
			})},
			{MsgTypes.geometry_msgs__TwistWithCovariance, new TypeInfo(MsgTypes.geometry_msgs__TwistWithCovariance, true, 
@"Twist twist
float64[36] covariance",
				 new Dictionary<string, MsgFieldInfo>{
					{"twist", new MsgFieldInfo("twist", false, typeof(TypedMessage<Twist>), false, "", false, "", true)},
					{"covariance", new MsgFieldInfo("covariance", true, typeof(double), false, "", true, "36", false)}
			})},
			{MsgTypes.geometry_msgs__TwistWithCovarianceStamped, new TypeInfo(MsgTypes.geometry_msgs__TwistWithCovarianceStamped, true, 
@"Header header
TwistWithCovariance twist",
				 new Dictionary<string, MsgFieldInfo>{
					{"header", new MsgFieldInfo("header", false, typeof(TypedMessage<Header>), false, "", false, "", true)},
					{"twist", new MsgFieldInfo("twist", false, typeof(TypedMessage<TwistWithCovariance>), false, "", false, "", true)}
			})},
			{MsgTypes.geometry_msgs__Vector3, new TypeInfo(MsgTypes.geometry_msgs__Vector3, false, 
@"float64 x
float64 y
float64 z",
				 new Dictionary<string, MsgFieldInfo>{
					{"x", new MsgFieldInfo("x", true, typeof(double), false, "", false, "", false)},
					{"y", new MsgFieldInfo("y", true, typeof(double), false, "", false, "", false)},
					{"z", new MsgFieldInfo("z", true, typeof(double), false, "", false, "", false)}
			})},
			{MsgTypes.geometry_msgs__Vector3Stamped, new TypeInfo(MsgTypes.geometry_msgs__Vector3Stamped, true, 
@"Header header
Vector3 vector",
				 new Dictionary<string, MsgFieldInfo>{
					{"header", new MsgFieldInfo("header", false, typeof(TypedMessage<Header>), false, "", false, "", true)},
					{"vector", new MsgFieldInfo("vector", false, typeof(TypedMessage<Vector3>), false, "", false, "", true)}
			})},
			{MsgTypes.geometry_msgs__Wrench, new TypeInfo(MsgTypes.geometry_msgs__Wrench, true, 
@"Vector3  force
Vector3  torque",
				 new Dictionary<string, MsgFieldInfo>{
					{"force", new MsgFieldInfo("force", false, typeof(TypedMessage<Vector3>), false, "", false, "", true)},
					{"torque", new MsgFieldInfo("torque", false, typeof(TypedMessage<Vector3>), false, "", false, "", true)}
			})},
			{MsgTypes.geometry_msgs__WrenchStamped, new TypeInfo(MsgTypes.geometry_msgs__WrenchStamped, true, 
@"Header header
Wrench wrench",
				 new Dictionary<string, MsgFieldInfo>{
					{"header", new MsgFieldInfo("header", false, typeof(TypedMessage<Header>), false, "", false, "", true)},
					{"wrench", new MsgFieldInfo("wrench", false, typeof(TypedMessage<Wrench>), false, "", false, "", true)}
			})},
			{MsgTypes.nav_msgs__GridCells, new TypeInfo(MsgTypes.nav_msgs__GridCells, true, 
@"Header header
float32 cell_width
float32 cell_height
geometry_msgs/Point[] cells",
				 new Dictionary<string, MsgFieldInfo>{
					{"header", new MsgFieldInfo("header", false, typeof(TypedMessage<Header>), false, "", false, "", true)},
					{"cell_width", new MsgFieldInfo("cell_width", true, typeof(double), false, "", false, "", false)},
					{"cell_height", new MsgFieldInfo("cell_height", true, typeof(double), false, "", false, "", false)},
					{"cells", new MsgFieldInfo("cells", false, typeof(TypedMessage<Point>), false, "", true, "", true)}
			})},
			{MsgTypes.nav_msgs__MapMetaData, new TypeInfo(MsgTypes.nav_msgs__MapMetaData, true, 
@"time map_load_time
float32 resolution
uint32 width
uint32 height
geometry_msgs/Pose origin",
				 new Dictionary<string, MsgFieldInfo>{
					{"map_load_time", new MsgFieldInfo("map_load_time", true, typeof(ulong), false, "", false, "", false)},
					{"resolution", new MsgFieldInfo("resolution", true, typeof(double), false, "", false, "", false)},
					{"width", new MsgFieldInfo("width", true, typeof(uint), false, "", false, "", false)},
					{"height", new MsgFieldInfo("height", true, typeof(uint), false, "", false, "", false)},
					{"origin", new MsgFieldInfo("origin", false, typeof(TypedMessage<Pose>), false, "", false, "", true)}
			})},
			{MsgTypes.nav_msgs__OccupancyGrid, new TypeInfo(MsgTypes.nav_msgs__OccupancyGrid, true, 
@"Header header
MapMetaData info
int8[] data",
				 new Dictionary<string, MsgFieldInfo>{
					{"header", new MsgFieldInfo("header", false, typeof(TypedMessage<Header>), false, "", false, "", true)},
					{"info", new MsgFieldInfo("info", false, typeof(TypedMessage<MapMetaData>), false, "", false, "", true)},
					{"data", new MsgFieldInfo("data", true, typeof(sbyte), false, "", true, "", false)}
			})},
			{MsgTypes.nav_msgs__Odometry, new TypeInfo(MsgTypes.nav_msgs__Odometry, true, 
@"Header header
string child_frame_id
geometry_msgs/PoseWithCovariance pose
geometry_msgs/TwistWithCovariance twist",
				 new Dictionary<string, MsgFieldInfo>{
					{"header", new MsgFieldInfo("header", false, typeof(TypedMessage<Header>), false, "", false, "", true)},
					{"child_frame_id", new MsgFieldInfo("child_frame_id", true, typeof(string), false, "", false, "", false)},
					{"pose", new MsgFieldInfo("pose", false, typeof(TypedMessage<PoseWithCovariance>), false, "", false, "", true)},
					{"twist", new MsgFieldInfo("twist", false, typeof(TypedMessage<TwistWithCovariance>), false, "", false, "", true)}
			})},
			{MsgTypes.nav_msgs__Path, new TypeInfo(MsgTypes.nav_msgs__Path, true, 
@"Header header
geometry_msgs/PoseStamped[] poses",
				 new Dictionary<string, MsgFieldInfo>{
					{"header", new MsgFieldInfo("header", false, typeof(TypedMessage<Header>), false, "", false, "", true)},
					{"poses", new MsgFieldInfo("poses", false, typeof(TypedMessage<PoseStamped>), false, "", true, "", true)}
			})},
			{MsgTypes.rosgraph_msgs__Log, new TypeInfo(MsgTypes.rosgraph_msgs__Log, true, 
@"byte DEBUG=1
byte INFO=2
byte WARN=4
byte ERROR=8
byte FATAL=16
Header header
byte level
string name
string msg
string file
string function
uint32 line
string[] topics",
				 new Dictionary<string, MsgFieldInfo>{
					{"DEBUG", new MsgFieldInfo("DEBUG", true, typeof(byte), true, "1", false, "", false)},
					{"INFO", new MsgFieldInfo("INFO", true, typeof(byte), true, "2", false, "", false)},
					{"WARN", new MsgFieldInfo("WARN", true, typeof(byte), true, "4", false, "", false)},
					{"ERROR", new MsgFieldInfo("ERROR", true, typeof(byte), true, "8", false, "", false)},
					{"FATAL", new MsgFieldInfo("FATAL", true, typeof(byte), true, "16", false, "", false)},
					{"header", new MsgFieldInfo("header", false, typeof(TypedMessage<Header>), false, "", false, "", true)},
					{"level", new MsgFieldInfo("level", true, typeof(byte), false, "", false, "", false)},
					{"name", new MsgFieldInfo("name", true, typeof(string), false, "", false, "", false)},
					{"msg", new MsgFieldInfo("msg", true, typeof(string), false, "", false, "", false)},
					{"file", new MsgFieldInfo("file", true, typeof(string), false, "", false, "", false)},
					{"function", new MsgFieldInfo("function", true, typeof(string), false, "", false, "", false)},
					{"line", new MsgFieldInfo("line", true, typeof(uint), false, "", false, "", false)},
					{"topics", new MsgFieldInfo("topics", true, typeof(string), false, "", true, "", false)}
			})},
			{MsgTypes.std_msgs__Bool, new TypeInfo(MsgTypes.std_msgs__Bool, false, 
@"bool data",
				 new Dictionary<string, MsgFieldInfo>{
					{"data", new MsgFieldInfo("data", true, typeof(bool), false, "", false, "", false)}
			})},
			{MsgTypes.std_msgs__Byte, new TypeInfo(MsgTypes.std_msgs__Byte, false, 
@"byte data",
				 new Dictionary<string, MsgFieldInfo>{
					{"data", new MsgFieldInfo("data", true, typeof(byte), false, "", false, "", false)}
			})},
			{MsgTypes.std_msgs__ByteMultiArray, new TypeInfo(MsgTypes.std_msgs__ByteMultiArray, true, 
@"MultiArrayLayout  layout
byte[]            data",
				 new Dictionary<string, MsgFieldInfo>{
					{"layout", new MsgFieldInfo("layout", false, typeof(TypedMessage<MultiArrayLayout>), false, "", false, "", true)},
					{"data", new MsgFieldInfo("data", true, typeof(byte), false, "", true, "", false)}
			})},
			{MsgTypes.std_msgs__Char, new TypeInfo(MsgTypes.std_msgs__Char, false, 
@"char data",
				 new Dictionary<string, MsgFieldInfo>{
					{"data", new MsgFieldInfo("data", true, typeof(char), false, "", false, "", false)}
			})},
			{MsgTypes.std_msgs__ColorRGBA, new TypeInfo(MsgTypes.std_msgs__ColorRGBA, false, 
@"float32 r
float32 g
float32 b
float32 a",
				 new Dictionary<string, MsgFieldInfo>{
					{"r", new MsgFieldInfo("r", true, typeof(double), false, "", false, "", false)},
					{"g", new MsgFieldInfo("g", true, typeof(double), false, "", false, "", false)},
					{"b", new MsgFieldInfo("b", true, typeof(double), false, "", false, "", false)},
					{"a", new MsgFieldInfo("a", true, typeof(double), false, "", false, "", false)}
			})},
			{MsgTypes.std_msgs__ConnectionHeader, new TypeInfo(MsgTypes.std_msgs__ConnectionHeader, true, 
@"byte DEBUG=1
byte INFO=2
byte WARN=4
byte ERROR=8
byte FATAL=16
Header header
byte level
string name
string msg
string file
string function
uint32 line
string[] topics",
				 new Dictionary<string, MsgFieldInfo>{
					{"DEBUG", new MsgFieldInfo("DEBUG", true, typeof(byte), true, "1", false, "", false)},
					{"INFO", new MsgFieldInfo("INFO", true, typeof(byte), true, "2", false, "", false)},
					{"WARN", new MsgFieldInfo("WARN", true, typeof(byte), true, "4", false, "", false)},
					{"ERROR", new MsgFieldInfo("ERROR", true, typeof(byte), true, "8", false, "", false)},
					{"FATAL", new MsgFieldInfo("FATAL", true, typeof(byte), true, "16", false, "", false)},
					{"header", new MsgFieldInfo("header", false, typeof(TypedMessage<Header>), false, "", false, "", true)},
					{"level", new MsgFieldInfo("level", true, typeof(byte), false, "", false, "", false)},
					{"name", new MsgFieldInfo("name", true, typeof(string), false, "", false, "", false)},
					{"msg", new MsgFieldInfo("msg", true, typeof(string), false, "", false, "", false)},
					{"file", new MsgFieldInfo("file", true, typeof(string), false, "", false, "", false)},
					{"function", new MsgFieldInfo("function", true, typeof(string), false, "", false, "", false)},
					{"line", new MsgFieldInfo("line", true, typeof(uint), false, "", false, "", false)},
					{"topics", new MsgFieldInfo("topics", true, typeof(string), false, "", true, "", false)}
			})},
			{MsgTypes.std_msgs__Duration, new TypeInfo(MsgTypes.std_msgs__Duration, false, 
@"uint64 data",
				 new Dictionary<string, MsgFieldInfo>{
					{"data", new MsgFieldInfo("data", true, typeof(ulong), false, "", false, "", false)}
			})},
			{MsgTypes.std_msgs__Empty, new TypeInfo(MsgTypes.std_msgs__Empty, false, 
@"",
				 new Dictionary<string, MsgFieldInfo>{

			})},
			{MsgTypes.std_msgs__Float32, new TypeInfo(MsgTypes.std_msgs__Float32, false, 
@"float32 data",
				 new Dictionary<string, MsgFieldInfo>{
					{"data", new MsgFieldInfo("data", true, typeof(double), false, "", false, "", false)}
			})},
			{MsgTypes.std_msgs__Float32MultiArray, new TypeInfo(MsgTypes.std_msgs__Float32MultiArray, true, 
@"MultiArrayLayout  layout
float32[]         data",
				 new Dictionary<string, MsgFieldInfo>{
					{"layout", new MsgFieldInfo("layout", false, typeof(TypedMessage<MultiArrayLayout>), false, "", false, "", true)},
					{"data", new MsgFieldInfo("data", true, typeof(double), false, "", true, "", false)}
			})},
			{MsgTypes.std_msgs__Float64, new TypeInfo(MsgTypes.std_msgs__Float64, false, 
@"float64 data",
				 new Dictionary<string, MsgFieldInfo>{
					{"data", new MsgFieldInfo("data", true, typeof(double), false, "", false, "", false)}
			})},
			{MsgTypes.std_msgs__Float64MultiArray, new TypeInfo(MsgTypes.std_msgs__Float64MultiArray, true, 
@"MultiArrayLayout  layout
float64[]         data",
				 new Dictionary<string, MsgFieldInfo>{
					{"layout", new MsgFieldInfo("layout", false, typeof(TypedMessage<MultiArrayLayout>), false, "", false, "", true)},
					{"data", new MsgFieldInfo("data", true, typeof(double), false, "", true, "", false)}
			})},
			{MsgTypes.std_msgs__Header, new TypeInfo(MsgTypes.std_msgs__Header, false, 
@"uint32 seq
time stamp
string frame_id",
				 new Dictionary<string, MsgFieldInfo>{
					{"seq", new MsgFieldInfo("seq", true, typeof(uint), false, "", false, "", false)},
					{"stamp", new MsgFieldInfo("stamp", true, typeof(ulong), false, "", false, "", false)},
					{"frame_id", new MsgFieldInfo("frame_id", true, typeof(string), false, "", false, "", false)}
			})},
			{MsgTypes.std_msgs__Int16, new TypeInfo(MsgTypes.std_msgs__Int16, false, 
@"int16 data",
				 new Dictionary<string, MsgFieldInfo>{
					{"data", new MsgFieldInfo("data", true, typeof(short), false, "", false, "", false)}
			})},
			{MsgTypes.std_msgs__Int16MultiArray, new TypeInfo(MsgTypes.std_msgs__Int16MultiArray, true, 
@"MultiArrayLayout  layout
int16[]           data",
				 new Dictionary<string, MsgFieldInfo>{
					{"layout", new MsgFieldInfo("layout", false, typeof(TypedMessage<MultiArrayLayout>), false, "", false, "", true)},
					{"data", new MsgFieldInfo("data", true, typeof(short), false, "", true, "", false)}
			})},
			{MsgTypes.std_msgs__Int32, new TypeInfo(MsgTypes.std_msgs__Int32, false, 
@"int32 data",
				 new Dictionary<string, MsgFieldInfo>{
					{"data", new MsgFieldInfo("data", true, typeof(int), false, "", false, "", false)}
			})},
			{MsgTypes.std_msgs__Int32MultiArray, new TypeInfo(MsgTypes.std_msgs__Int32MultiArray, true, 
@"MultiArrayLayout  layout
int32[]           data",
				 new Dictionary<string, MsgFieldInfo>{
					{"layout", new MsgFieldInfo("layout", false, typeof(TypedMessage<MultiArrayLayout>), false, "", false, "", true)},
					{"data", new MsgFieldInfo("data", true, typeof(int), false, "", true, "", false)}
			})},
			{MsgTypes.std_msgs__Int64, new TypeInfo(MsgTypes.std_msgs__Int64, false, 
@"int64 data",
				 new Dictionary<string, MsgFieldInfo>{
					{"data", new MsgFieldInfo("data", true, typeof(long), false, "", false, "", false)}
			})},
			{MsgTypes.std_msgs__Int64MultiArray, new TypeInfo(MsgTypes.std_msgs__Int64MultiArray, true, 
@"MultiArrayLayout  layout
int64[]           data",
				 new Dictionary<string, MsgFieldInfo>{
					{"layout", new MsgFieldInfo("layout", false, typeof(TypedMessage<MultiArrayLayout>), false, "", false, "", true)},
					{"data", new MsgFieldInfo("data", true, typeof(long), false, "", true, "", false)}
			})},
			{MsgTypes.std_msgs__Int8, new TypeInfo(MsgTypes.std_msgs__Int8, false, 
@"int8 data",
				 new Dictionary<string, MsgFieldInfo>{
					{"data", new MsgFieldInfo("data", true, typeof(sbyte), false, "", false, "", false)}
			})},
			{MsgTypes.std_msgs__Int8MultiArray, new TypeInfo(MsgTypes.std_msgs__Int8MultiArray, true, 
@"MultiArrayLayout  layout
int8[]            data",
				 new Dictionary<string, MsgFieldInfo>{
					{"layout", new MsgFieldInfo("layout", false, typeof(TypedMessage<MultiArrayLayout>), false, "", false, "", true)},
					{"data", new MsgFieldInfo("data", true, typeof(sbyte), false, "", true, "", false)}
			})},
			{MsgTypes.std_msgs__MultiArrayDimension, new TypeInfo(MsgTypes.std_msgs__MultiArrayDimension, false, 
@"string label
uint32 size
uint32 stride",
				 new Dictionary<string, MsgFieldInfo>{
					{"label", new MsgFieldInfo("label", true, typeof(string), false, "", false, "", false)},
					{"size", new MsgFieldInfo("size", true, typeof(uint), false, "", false, "", false)},
					{"stride", new MsgFieldInfo("stride", true, typeof(uint), false, "", false, "", false)}
			})},
			{MsgTypes.std_msgs__MultiArrayLayout, new TypeInfo(MsgTypes.std_msgs__MultiArrayLayout, true, 
@"MultiArrayDimension[] dim
uint32 data_offset",
				 new Dictionary<string, MsgFieldInfo>{
					{"dim", new MsgFieldInfo("dim", false, typeof(TypedMessage<MultiArrayDimension>), false, "", true, "", true)},
					{"data_offset", new MsgFieldInfo("data_offset", true, typeof(uint), false, "", false, "", false)}
			})},
			{MsgTypes.std_msgs__String, new TypeInfo(MsgTypes.std_msgs__String, false, 
@"string data",
				 new Dictionary<string, MsgFieldInfo>{
					{"data", new MsgFieldInfo("data", true, typeof(string), false, "", false, "", false)}
			})},
			{MsgTypes.std_msgs__Time, new TypeInfo(MsgTypes.std_msgs__Time, false, 
@"uint64 data",
				 new Dictionary<string, MsgFieldInfo>{
					{"data", new MsgFieldInfo("data", true, typeof(ulong), false, "", false, "", false)}
			})},
			{MsgTypes.std_msgs__UInt16, new TypeInfo(MsgTypes.std_msgs__UInt16, false, 
@"uint16 data",
				 new Dictionary<string, MsgFieldInfo>{
					{"data", new MsgFieldInfo("data", true, typeof(ushort), false, "", false, "", false)}
			})},
			{MsgTypes.std_msgs__UInt16MultiArray, new TypeInfo(MsgTypes.std_msgs__UInt16MultiArray, true, 
@"MultiArrayLayout  layout
uint16[]            data",
				 new Dictionary<string, MsgFieldInfo>{
					{"layout", new MsgFieldInfo("layout", false, typeof(TypedMessage<MultiArrayLayout>), false, "", false, "", true)},
					{"data", new MsgFieldInfo("data", true, typeof(ushort), false, "", true, "", false)}
			})},
			{MsgTypes.std_msgs__UInt32, new TypeInfo(MsgTypes.std_msgs__UInt32, false, 
@"uint32 data",
				 new Dictionary<string, MsgFieldInfo>{
					{"data", new MsgFieldInfo("data", true, typeof(uint), false, "", false, "", false)}
			})},
			{MsgTypes.std_msgs__UInt32MultiArray, new TypeInfo(MsgTypes.std_msgs__UInt32MultiArray, true, 
@"MultiArrayLayout  layout
uint32[]          data",
				 new Dictionary<string, MsgFieldInfo>{
					{"layout", new MsgFieldInfo("layout", false, typeof(TypedMessage<MultiArrayLayout>), false, "", false, "", true)},
					{"data", new MsgFieldInfo("data", true, typeof(uint), false, "", true, "", false)}
			})},
			{MsgTypes.std_msgs__UInt64, new TypeInfo(MsgTypes.std_msgs__UInt64, false, 
@"uint64 data",
				 new Dictionary<string, MsgFieldInfo>{
					{"data", new MsgFieldInfo("data", true, typeof(ulong), false, "", false, "", false)}
			})},
			{MsgTypes.std_msgs__UInt64MultiArray, new TypeInfo(MsgTypes.std_msgs__UInt64MultiArray, true, 
@"MultiArrayLayout  layout
uint64[]          data",
				 new Dictionary<string, MsgFieldInfo>{
					{"layout", new MsgFieldInfo("layout", false, typeof(TypedMessage<MultiArrayLayout>), false, "", false, "", true)},
					{"data", new MsgFieldInfo("data", true, typeof(ulong), false, "", true, "", false)}
			})},
			{MsgTypes.std_msgs__UInt8, new TypeInfo(MsgTypes.std_msgs__UInt8, false, 
@"uint8 data",
				 new Dictionary<string, MsgFieldInfo>{
					{"data", new MsgFieldInfo("data", true, typeof(byte), false, "", false, "", false)}
			})},
			{MsgTypes.std_msgs__UInt8MultiArray, new TypeInfo(MsgTypes.std_msgs__UInt8MultiArray, true, 
@"MultiArrayLayout  layout
uint8[]           data",
				 new Dictionary<string, MsgFieldInfo>{
					{"layout", new MsgFieldInfo("layout", false, typeof(TypedMessage<MultiArrayLayout>), false, "", false, "", true)},
					{"data", new MsgFieldInfo("data", true, typeof(byte), false, "", true, "", false)}
			})}
		};	}

	public enum MsgTypes
	{
		Unknown,
		custom_msgs__arraytest,
		geometry_msgs__Point,
		geometry_msgs__Point32,
		geometry_msgs__PointStamped,
		geometry_msgs__Polygon,
		geometry_msgs__PolygonStamped,
		geometry_msgs__Pose,
		geometry_msgs__Pose2D,
		geometry_msgs__PoseArray,
		geometry_msgs__PoseStamped,
		geometry_msgs__PoseWithCovariance,
		geometry_msgs__PoseWithCovarianceStamped,
		geometry_msgs__Quaternion,
		geometry_msgs__QuaternionStamped,
		geometry_msgs__Transform,
		geometry_msgs__TransformStamped,
		geometry_msgs__Twist,
		geometry_msgs__TwistStamped,
		geometry_msgs__TwistWithCovariance,
		geometry_msgs__TwistWithCovarianceStamped,
		geometry_msgs__Vector3,
		geometry_msgs__Vector3Stamped,
		geometry_msgs__Wrench,
		geometry_msgs__WrenchStamped,
		nav_msgs__GridCells,
		nav_msgs__MapMetaData,
		nav_msgs__OccupancyGrid,
		nav_msgs__Odometry,
		nav_msgs__Path,
		rosgraph_msgs__Log,
		std_msgs__Bool,
		std_msgs__Byte,
		std_msgs__ByteMultiArray,
		std_msgs__Char,
		std_msgs__ColorRGBA,
		std_msgs__ConnectionHeader,
		std_msgs__Duration,
		std_msgs__Empty,
		std_msgs__Float32,
		std_msgs__Float32MultiArray,
		std_msgs__Float64,
		std_msgs__Float64MultiArray,
		std_msgs__Header,
		std_msgs__Int16,
		std_msgs__Int16MultiArray,
		std_msgs__Int32,
		std_msgs__Int32MultiArray,
		std_msgs__Int64,
		std_msgs__Int64MultiArray,
		std_msgs__Int8,
		std_msgs__Int8MultiArray,
		std_msgs__MultiArrayDimension,
		std_msgs__MultiArrayLayout,
		std_msgs__String,
		std_msgs__Time,
		std_msgs__UInt16,
		std_msgs__UInt16MultiArray,
		std_msgs__UInt32,
		std_msgs__UInt32MultiArray,
		std_msgs__UInt64,
		std_msgs__UInt64MultiArray,
		std_msgs__UInt8,
		std_msgs__UInt8MultiArray
	}
}
