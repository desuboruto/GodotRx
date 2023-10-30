using System;
using System.Reactive;
using Godot;
using Array = Godot.Collections.Array;
using Range = Godot.Range;

namespace GodotRx
{
    public static class SignalExtensions
    {
        public static IObservable<Unit> OnScriptChanged(this GodotObject obj)
        {
            return obj.ObserveSignal("script_changed");
        }

        public static IObservable<Unit> OnChanged(this Resource obj)
        {
            return obj.ObserveSignal("changed");
        }

        public static IObservable<Unit> OnConnectedToServer(this MultiplayerApi obj)
        {
            return obj.ObserveSignal("connected_to_server");
        }

        public static IObservable<Unit> OnConnectionFailed(this MultiplayerApi obj)
        {
            return obj.ObserveSignal("connection_failed");
        }

        public static IObservable<(int Id, byte[] Packet)> OnNetworkPeerPacket(this MultiplayerApi obj)
        {
            return obj.ObserveSignal<int, byte[]>("network_peer_packet");
        }

        public static IObservable<int> OnNetworkPeerDisconnected(this MultiplayerApi obj)
        {
            return obj.ObserveSignal<int>("network_peer_disconnected");
        }

        public static IObservable<int> OnNetworkPeerConnected(this MultiplayerApi obj)
        {
            return obj.ObserveSignal<int>("network_peer_connected");
        }

        public static IObservable<Unit> OnServerDisconnected(this MultiplayerApi obj)
        {
            return obj.ObserveSignal("server_disconnected");
        }

        public static IObservable<Unit> OnConnectionFailed(this MultiplayerPeer obj)
        {
            return obj.ObserveSignal("connection_failed");
        }

        public static IObservable<Unit> OnConnectionSucceeded(this MultiplayerPeer obj)
        {
            return obj.ObserveSignal("connection_succeeded");
        }

        public static IObservable<int> OnPeerDisconnected(this MultiplayerPeer obj)
        {
            return obj.ObserveSignal<int>("peer_disconnected");
        }

        public static IObservable<int> OnPeerConnected(this MultiplayerPeer obj)
        {
            return obj.ObserveSignal<int>("peer_connected");
        }

        public static IObservable<Unit> OnServerDisconnected(this MultiplayerPeer obj)
        {
            return obj.ObserveSignal("server_disconnected");
        }

        public static IObservable<(string Permission, bool Granted)> OnRequestPermissionsResult(this MainLoop obj)
        {
            return obj.ObserveSignal<string, bool>("on_request_permissions_result");
        }

        public static IObservable<Unit> OnVersionChanged(this UndoRedo obj)
        {
            return obj.ObserveSignal("version_changed");
        }

        public static IObservable<Unit> OnRenamed(this Node obj)
        {
            return obj.ObserveSignal("renamed");
        }

        public static IObservable<Unit> OnReady(this Node obj)
        {
            return obj.ObserveSignal("ready");
        }

        public static IObservable<Unit> OnTreeEntered(this Node obj)
        {
            return obj.ObserveSignal("tree_entered");
        }

        public static IObservable<Unit> OnTreeExiting(this Node obj)
        {
            return obj.ObserveSignal("tree_exiting");
        }

        public static IObservable<Unit> OnTreeExited(this Node obj)
        {
            return obj.ObserveSignal("tree_exited");
        }

        public static IObservable<Unit> OnSizeChanged(this SubViewport obj)
        {
            return obj.ObserveSignal("size_changed");
        }

        public static IObservable<Control> OnGuiFocusChanged(this SubViewport obj)
        {
            return obj.ObserveSignal<Control>("gui_focus_changed");
        }

        public static IObservable<Unit> OnMouseExited(this Control obj)
        {
            return obj.ObserveSignal("mouse_exited");
        }

        public static IObservable<InputEvent> OnGuiInput(this Control obj)
        {
            return obj.ObserveSignal<InputEvent>("gui_input");
        }

        public static IObservable<Unit> OnModalClosed(this Control obj)
        {
            return obj.ObserveSignal("modal_closed");
        }

        public static IObservable<Unit> OnFocusEntered(this Control obj)
        {
            return obj.ObserveSignal("focus_entered");
        }

        public static IObservable<Unit> OnResized(this Control obj)
        {
            return obj.ObserveSignal("resized");
        }

        public static IObservable<Unit> OnMinimumSizeChanged(this Control obj)
        {
            return obj.ObserveSignal("minimum_size_changed");
        }

        public static IObservable<Unit> OnMouseEntered(this Control obj)
        {
            return obj.ObserveSignal("mouse_entered");
        }

        public static IObservable<Unit> OnSizeFlagsChanged(this Control obj)
        {
            return obj.ObserveSignal("size_flags_changed");
        }

        public static IObservable<Unit> OnFocusExited(this Control obj)
        {
            return obj.ObserveSignal("focus_exited");
        }

        public static IObservable<(int Result, int ResponseCode, string[] Headers, byte[] Body)> OnRequestCompleted(
            this HttpRequest obj)
        {
            return obj.ObserveSignal<int, int, string[], byte[]>("request_completed");
        }

        public static IObservable<Unit> OnTimeout(this Timer obj)
        {
            return obj.ObserveSignal("timeout");
        }

        public static IObservable<Unit> OnItemRectChanged(this CanvasItem obj)
        {
            return obj.ObserveSignal("item_rect_changed");
        }

        public static IObservable<Unit> OnDraw(this CanvasItem obj)
        {
            return obj.ObserveSignal("draw");
        }

        public static IObservable<Unit> OnVisibilityChanged(this CanvasItem obj)
        {
            return obj.ObserveSignal("visibility_changed");
        }

        public static IObservable<Unit> OnHide(this CanvasItem obj)
        {
            return obj.ObserveSignal("hide");
        }

        public static IObservable<Unit> OnButtonDown(this BaseButton obj)
        {
            return obj.ObserveSignal("button_down");
        }

        public static IObservable<bool> OnToggled(this BaseButton obj)
        {
            return obj.ObserveSignal<bool>("toggled");
        }

        public static IObservable<Unit> OnPressed(this BaseButton obj)
        {
            return obj.ObserveSignal("pressed");
        }

        public static IObservable<Unit> OnButtonUp(this BaseButton obj)
        {
            return obj.ObserveSignal("button_up");
        }

        public static IObservable<float> OnValueChanged(this Range obj)
        {
            return obj.ObserveSignal<float>("value_changed");
        }

        public static IObservable<Unit> OnChanged(this Range obj)
        {
            return obj.ObserveSignal("changed");
        }

        public static IObservable<string[]> OnFilesSelected(this FileDialog obj)
        {
            return obj.ObserveSignal<string[]>("files_selected");
        }

        public static IObservable<string> OnDirSelected(this FileDialog obj)
        {
            return obj.ObserveSignal<string>("dir_selected");
        }

        public static IObservable<string> OnFileSelected(this FileDialog obj)
        {
            return obj.ObserveSignal<string>("file_selected");
        }

        public static IObservable<Unit> OnConfirmed(this AcceptDialog obj)
        {
            return obj.ObserveSignal("confirmed");
        }

        public static IObservable<string> OnCustomAction(this AcceptDialog obj)
        {
            return obj.ObserveSignal<string>("custom_action");
        }

        public static IObservable<Unit> OnScrolling(this ScrollBar obj)
        {
            return obj.ObserveSignal("scrolling");
        }

        public static IObservable<Unit> OnAboutToShow(this MenuButton obj)
        {
            return obj.ObserveSignal("about_to_show");
        }

        public static IObservable<Unit> OnPopupHide(this Popup obj)
        {
            return obj.ObserveSignal("popup_hide");
        }

        public static IObservable<Unit> OnAboutToShow(this Popup obj)
        {
            return obj.ObserveSignal("about_to_show");
        }

        public static IObservable<Unit> OnTextureChanged(this NinePatchRect obj)
        {
            return obj.ObserveSignal("texture_changed");
        }

        public static IObservable<Unit> OnPrePopupPressed(this TabContainer obj)
        {
            return obj.ObserveSignal("pre_popup_pressed");
        }

        public static IObservable<int> OnTabSelected(this TabContainer obj)
        {
            return obj.ObserveSignal<int>("tab_selected");
        }

        public static IObservable<int> OnTabChanged(this TabContainer obj)
        {
            return obj.ObserveSignal<int>("tab_changed");
        }

        public static IObservable<Unit> OnSortChildren(this Container obj)
        {
            return obj.ObserveSignal("sort_children");
        }

        public static IObservable<int> OnTabClose(this TabBar obj)
        {
            return obj.ObserveSignal<int>("tab_close");
        }

        public static IObservable<int> OnTabClicked(this TabBar obj)
        {
            return obj.ObserveSignal<int>("tab_clicked");
        }

        public static IObservable<int> OnRepositionActiveTabRequest(this TabBar obj)
        {
            return obj.ObserveSignal<int>("reposition_active_tab_request");
        }

        public static IObservable<int> OnRightButtonPressed(this TabBar obj)
        {
            return obj.ObserveSignal<int>("right_button_pressed");
        }

        public static IObservable<int> OnTabChanged(this TabBar obj)
        {
            return obj.ObserveSignal<int>("tab_changed");
        }

        public static IObservable<int> OnTabHover(this TabBar obj)
        {
            return obj.ObserveSignal<int>("tab_hover");
        }

        public static IObservable<Unit> OnScrollStarted(this ScrollContainer obj)
        {
            return obj.ObserveSignal("scroll_started");
        }

        public static IObservable<Unit> OnScrollEnded(this ScrollContainer obj)
        {
            return obj.ObserveSignal("scroll_ended");
        }

        public static IObservable<int> OnItemActivated(this ItemList obj)
        {
            return obj.ObserveSignal<int>("item_activated");
        }

        public static IObservable<(int Index, bool Selected)> OnMultiSelected(this ItemList obj)
        {
            return obj.ObserveSignal<int, bool>("multi_selected");
        }

        public static IObservable<Unit> OnNothingSelected(this ItemList obj)
        {
            return obj.ObserveSignal("nothing_selected");
        }

        public static IObservable<Vector2> OnRmbClicked(this ItemList obj)
        {
            return obj.ObserveSignal<Vector2>("rmb_clicked");
        }

        public static IObservable<(int Index, Vector2 AtPosition)> OnItemRmbSelected(this ItemList obj)
        {
            return obj.ObserveSignal<int, Vector2>("item_rmb_selected");
        }

        public static IObservable<int> OnItemSelected(this ItemList obj)
        {
            return obj.ObserveSignal<int>("item_selected");
        }

        public static IObservable<string> OnTextEntered(this LineEdit obj)
        {
            return obj.ObserveSignal<string>("text_entered");
        }

        public static IObservable<string> OnTextChanged(this LineEdit obj)
        {
            return obj.ObserveSignal<string>("text_changed");
        }

        public static IObservable<Unit> OnTextChangeRejected(this LineEdit obj)
        {
            return obj.ObserveSignal("text_change_rejected");
        }

        public static IObservable<Unit> OnFinished(this VideoStreamPlayer obj)
        {
            return obj.ObserveSignal("finished");
        }

        public static IObservable<int> OnIndexPressed(this PopupMenu obj)
        {
            return obj.ObserveSignal<int>("index_pressed");
        }

        public static IObservable<int> OnIdFocused(this PopupMenu obj)
        {
            return obj.ObserveSignal<int>("id_focused");
        }

        public static IObservable<int> OnIdPressed(this PopupMenu obj)
        {
            return obj.ObserveSignal<int>("id_pressed");
        }

        public static IObservable<Unit> OnItemActivated(this Tree obj)
        {
            return obj.ObserveSignal("item_activated");
        }

        public static IObservable<(TreeItem Item, int Column, bool Selected)> OnMultiSelected(this Tree obj)
        {
            return obj.ObserveSignal<TreeItem, int, bool>("multi_selected");
        }

        public static IObservable<int> OnColumnTitlePressed(this Tree obj)
        {
            return obj.ObserveSignal<int>("column_title_pressed");
        }

        public static IObservable<bool> OnCustomPopupEdited(this Tree obj)
        {
            return obj.ObserveSignal<bool>("custom_popup_edited");
        }

        public static IObservable<TreeItem> OnItemCollapsed(this Tree obj)
        {
            return obj.ObserveSignal<TreeItem>("item_collapsed");
        }

        public static IObservable<Unit> OnItemRmbEdited(this Tree obj)
        {
            return obj.ObserveSignal("item_rmb_edited");
        }

        public static IObservable<Unit> OnItemEdited(this Tree obj)
        {
            return obj.ObserveSignal("item_edited");
        }

        public static IObservable<Vector2> OnEmptyTreeRmbSelected(this Tree obj)
        {
            return obj.ObserveSignal<Vector2>("empty_tree_rmb_selected");
        }

        public static IObservable<Unit> OnNothingSelected(this Tree obj)
        {
            return obj.ObserveSignal("nothing_selected");
        }

        public static IObservable<Unit> OnItemDoubleClicked(this Tree obj)
        {
            return obj.ObserveSignal("item_double_clicked");
        }

        public static IObservable<Vector2> OnEmptyRmb(this Tree obj)
        {
            return obj.ObserveSignal<Vector2>("empty_rmb");
        }

        public static IObservable<Vector2> OnItemRmbSelected(this Tree obj)
        {
            return obj.ObserveSignal<Vector2>("item_rmb_selected");
        }

        public static IObservable<Unit> OnItemSelected(this Tree obj)
        {
            return obj.ObserveSignal("item_selected");
        }

        public static IObservable<Unit> OnCellSelected(this Tree obj)
        {
            return obj.ObserveSignal("cell_selected");
        }

        public static IObservable<(TreeItem Item, int Column, int Id)> OnButtonPressed(this Tree obj)
        {
            return obj.ObserveSignal<TreeItem, int, int>("button_pressed");
        }

        public static IObservable<Unit> OnItemCustomButtonPressed(this Tree obj)
        {
            return obj.ObserveSignal("item_custom_button_pressed");
        }

        public static IObservable<int> OnBreakpointToggled(this TextEdit obj)
        {
            return obj.ObserveSignal<int>("breakpoint_toggled");
        }

        public static IObservable<Unit> OnTextChanged(this TextEdit obj)
        {
            return obj.ObserveSignal("text_changed");
        }

        public static IObservable<(string Symbol, int Row, int Column)> OnSymbolLookup(this TextEdit obj)
        {
            return obj.ObserveSignal<string, int, int>("symbol_lookup");
        }

        public static IObservable<Unit> OnCursorChanged(this TextEdit obj)
        {
            return obj.ObserveSignal("cursor_changed");
        }

        public static IObservable<(int Row, string Info)> OnInfoClicked(this TextEdit obj)
        {
            return obj.ObserveSignal<int, string>("info_clicked");
        }

        public static IObservable<Unit> OnRequestCompletion(this TextEdit obj)
        {
            return obj.ObserveSignal("request_completion");
        }

        public static IObservable<int> OnItemFocused(this OptionButton obj)
        {
            return obj.ObserveSignal<int>("item_focused");
        }

        public static IObservable<int> OnItemSelected(this OptionButton obj)
        {
            return obj.ObserveSignal<int>("item_selected");
        }

        public static IObservable<Color> OnPresetRemoved(this ColorPicker obj)
        {
            return obj.ObserveSignal<Color>("preset_removed");
        }

        public static IObservable<Color> OnPresetAdded(this ColorPicker obj)
        {
            return obj.ObserveSignal<Color>("preset_added");
        }

        public static IObservable<Color> OnColorChanged(this ColorPicker obj)
        {
            return obj.ObserveSignal<Color>("color_changed");
        }

        public static IObservable<object> OnMetaClicked(this RichTextLabel obj)
        {
            return obj.ObserveSignal<object>("meta_clicked");
        }

        public static IObservable<object> OnMetaHoverStarted(this RichTextLabel obj)
        {
            return obj.ObserveSignal<object>("meta_hover_started");
        }

        public static IObservable<object> OnMetaHoverEnded(this RichTextLabel obj)
        {
            return obj.ObserveSignal<object>("meta_hover_ended");
        }

        public static IObservable<Unit> OnPickerCreated(this ColorPickerButton obj)
        {
            return obj.ObserveSignal("picker_created");
        }

        public static IObservable<Unit> OnPopupClosed(this ColorPickerButton obj)
        {
            return obj.ObserveSignal("popup_closed");
        }

        public static IObservable<Color> OnColorChanged(this ColorPickerButton obj)
        {
            return obj.ObserveSignal<Color>("color_changed");
        }

        public static IObservable<int> OnDragged(this SplitContainer obj)
        {
            return obj.ObserveSignal<int>("dragged");
        }

        public static IObservable<Unit> OnRaiseRequest(this GraphNode obj)
        {
            return obj.ObserveSignal("raise_request");
        }

        public static IObservable<Unit> OnCloseRequest(this GraphNode obj)
        {
            return obj.ObserveSignal("close_request");
        }

        public static IObservable<(Vector2 From, Vector2 To)> OnDragged(this GraphNode obj)
        {
            return obj.ObserveSignal<Vector2, Vector2>("dragged");
        }

        public static IObservable<Unit> OnOffsetChanged(this GraphNode obj)
        {
            return obj.ObserveSignal("offset_changed");
        }

        public static IObservable<Vector2> OnResizeRequest(this GraphNode obj)
        {
            return obj.ObserveSignal<Vector2>("resize_request");
        }

        public static IObservable<Unit> OnDeleteNodesRequest(this GraphEdit obj)
        {
            return obj.ObserveSignal("delete_nodes_request");
        }

        public static IObservable<Unit> OnCopyNodesRequest(this GraphEdit obj)
        {
            return obj.ObserveSignal("copy_nodes_request");
        }

        public static IObservable<Unit> OnDuplicateNodesRequest(this GraphEdit obj)
        {
            return obj.ObserveSignal("duplicate_nodes_request");
        }

        public static IObservable<Vector2> OnPopupRequest(this GraphEdit obj)
        {
            return obj.ObserveSignal<Vector2>("popup_request");
        }

        public static IObservable<Unit> OnPasteNodesRequest(this GraphEdit obj)
        {
            return obj.ObserveSignal("paste_nodes_request");
        }

        public static IObservable<Vector2> OnScrollOffsetChanged(this GraphEdit obj)
        {
            return obj.ObserveSignal<Vector2>("scroll_offset_changed");
        }

        public static IObservable<Node> OnNodeSelected(this GraphEdit obj)
        {
            return obj.ObserveSignal<Node>("node_selected");
        }

        public static IObservable<Unit> OnBeginNodeMove(this GraphEdit obj)
        {
            return obj.ObserveSignal("_begin_node_move");
        }

        public static IObservable<(string From, int FromSlot, Vector2 ReleasePosition)> OnConnectionToEmpty(
            this GraphEdit obj)
        {
            return obj.ObserveSignal<string, int, Vector2>("connection_to_empty");
        }

        public static IObservable<(string From, int FromSlot, string To, int ToSlot)> OnDisconnectionRequest(
            this GraphEdit obj)
        {
            return obj.ObserveSignal<string, int, string, int>("disconnection_request");
        }

        public static IObservable<(string From, int FromSlot, string To, int ToSlot)> OnConnectionRequest(
            this GraphEdit obj)
        {
            return obj.ObserveSignal<string, int, string, int>("connection_request");
        }

        public static IObservable<Unit> OnEndNodeMove(this GraphEdit obj)
        {
            return obj.ObserveSignal("_end_node_move");
        }

        public static IObservable<(string To, int ToSlot, Vector2 ReleasePosition)> OnConnectionFromEmpty(
            this GraphEdit obj)
        {
            return obj.ObserveSignal<string, int, Vector2>("connection_from_empty");
        }

        public static IObservable<Node> OnNodeUnselected(this GraphEdit obj)
        {
            return obj.ObserveSignal<Node>("node_unselected");
        }

        public static IObservable<Unit> OnVisibilityChanged(this Node3D obj)
        {
            return obj.ObserveSignal("visibility_changed");
        }

        public static IObservable<Unit> OnCachesCleared(this AnimationPlayer obj)
        {
            return obj.ObserveSignal("caches_cleared");
        }

        public static IObservable<string> OnAnimationStarted(this AnimationPlayer obj)
        {
            return obj.ObserveSignal<string>("animation_started");
        }

        public static IObservable<(string OldName, string NewName)> OnAnimationChanged(this AnimationPlayer obj)
        {
            return obj.ObserveSignal<string, string>("animation_changed");
        }

        public static IObservable<string> OnAnimationFinished(this AnimationPlayer obj)
        {
            return obj.ObserveSignal<string>("animation_finished");
        }

        public static IObservable<(GodotObject Object, NodePath Key, float Elapsed, GodotObject Value)> OnTweenStep(
            this Tween obj)
        {
            return obj.ObserveSignal<GodotObject, NodePath, float, GodotObject>("tween_step");
        }

        public static IObservable<Unit> OnTweenAllCompleted(this Tween obj)
        {
            return obj.ObserveSignal("tween_all_completed");
        }

        public static IObservable<(GodotObject Object, NodePath Key)> OnTweenCompleted(this Tween obj)
        {
            return obj.ObserveSignal<GodotObject, NodePath>("tween_completed");
        }

        public static IObservable<(GodotObject Object, NodePath Key)> OnTweenStarted(this Tween obj)
        {
            return obj.ObserveSignal<GodotObject, NodePath>("tween_started");
        }

        public static IObservable<Unit> OnRemovedFromGraph(this AnimationNode obj)
        {
            return obj.ObserveSignal("removed_from_graph");
        }

        public static IObservable<Unit> OnTreeChanged(this AnimationNode obj)
        {
            return obj.ObserveSignal("tree_changed");
        }

        public static IObservable<Unit> OnTrianglesUpdated(this AnimationNodeBlendSpace2D obj)
        {
            return obj.ObserveSignal("triangles_updated");
        }

        public static IObservable<Unit> OnAdvanceConditionChanged(this AnimationNodeStateMachineTransition obj)
        {
            return obj.ObserveSignal("advance_condition_changed");
        }

        public static IObservable<Mesh> OnMeshUpdated(this XRController3D obj)
        {
            return obj.ObserveSignal<Mesh>("mesh_updated");
        }

        public static IObservable<int> OnButtonRelease(this XRController3D obj)
        {
            return obj.ObserveSignal<int>("button_release");
        }

        public static IObservable<int> OnButtonPressed(this XRController3D obj)
        {
            return obj.ObserveSignal<int>("button_pressed");
        }

        public static IObservable<Mesh> OnMeshUpdated(this XRAnchor3D obj)
        {
            return obj.ObserveSignal<Mesh>("mesh_updated");
        }

        public static IObservable<Unit> OnFrameChanged(this Sprite3D obj)
        {
            return obj.ObserveSignal("frame_changed");
        }

        public static IObservable<Unit> OnFrameChanged(this AnimatedSprite3D obj)
        {
            return obj.ObserveSignal("frame_changed");
        }

        public static IObservable<Unit> OnRangeChanged(this Curve obj)
        {
            return obj.ObserveSignal("range_changed");
        }

        public static IObservable<Unit> OnMouseExited(this CollisionObject3D obj)
        {
            return obj.ObserveSignal("mouse_exited");
        }

        public static IObservable<Unit> OnMouseEntered(this CollisionObject3D obj)
        {
            return obj.ObserveSignal("mouse_entered");
        }

        public static
            IObservable<(Node Camera3D, InputEvent Event, Vector3 ClickPosition, Vector3 ClickNormal, int ShapeIdx)>
            OnInputEvent(this CollisionObject3D obj)
        {
            return obj.ObserveSignal<Node, InputEvent, Vector3, Vector3, int>("input_event");
        }

        public static IObservable<Node> OnBodyEntered(this RigidBody3D obj)
        {
            return obj.ObserveSignal<Node>("body_entered");
        }

        public static IObservable<(int BodyId, Node Body, int BodyShape, int LocalShape)> OnBodyShapeEntered(
            this RigidBody3D obj)
        {
            return obj.ObserveSignal<int, Node, int, int>("body_shape_entered");
        }

        public static IObservable<Unit> OnSleepingStateChanged(this RigidBody3D obj)
        {
            return obj.ObserveSignal("sleeping_state_changed");
        }

        public static IObservable<Node> OnBodyExited(this RigidBody3D obj)
        {
            return obj.ObserveSignal<Node>("body_exited");
        }

        public static IObservable<(int BodyId, Node Body, int BodyShape, int LocalShape)> OnBodyShapeExited(
            this RigidBody3D obj)
        {
            return obj.ObserveSignal<int, Node, int, int>("body_shape_exited");
        }

        public static IObservable<Area3D> OnAreaExited(this Area3D obj)
        {
            return obj.ObserveSignal<Area3D>("area_exited");
        }

        public static IObservable<(int AreaId, Area3D Area3D, int AreaShape, int SelfShape)> OnAreaShapeExited(
            this Area3D obj)
        {
            return obj.ObserveSignal<int, Area3D, int, int>("area_shape_exited");
        }

        public static IObservable<Node> OnBodyEntered(this Area3D obj)
        {
            return obj.ObserveSignal<Node>("body_entered");
        }

        public static IObservable<(int BodyId, Node Body, int BodyShape, int AreaShape)> OnBodyShapeEntered(
            this Area3D obj)
        {
            return obj.ObserveSignal<int, Node, int, int>("body_shape_entered");
        }

        public static IObservable<Area3D> OnAreaEntered(this Area3D obj)
        {
            return obj.ObserveSignal<Area3D>("area_entered");
        }

        public static IObservable<(int AreaId, Area3D Area3D, int AreaShape, int SelfShape)> OnAreaShapeEntered(
            this Area3D obj)
        {
            return obj.ObserveSignal<int, Area3D, int, int>("area_shape_entered");
        }

        public static IObservable<Node> OnBodyExited(this Area3D obj)
        {
            return obj.ObserveSignal<Node>("body_exited");
        }

        public static IObservable<(int BodyId, Node Body, int BodyShape, int AreaShape)> OnBodyShapeExited(
            this Area3D obj)
        {
            return obj.ObserveSignal<int, Node, int, int>("body_shape_exited");
        }

        public static IObservable<Unit> OnCurveChanged(this Path3D obj)
        {
            return obj.ObserveSignal("curve_changed");
        }

        public static IObservable<Camera3D> OnCameraExited(this VisibleOnScreenNotifier3D obj)
        {
            return obj.ObserveSignal<Camera3D>("camera_exited");
        }

        public static IObservable<Unit> OnScreenEntered(this VisibleOnScreenNotifier3D obj)
        {
            return obj.ObserveSignal("screen_entered");
        }

        public static IObservable<Camera3D> OnCameraEntered(this VisibleOnScreenNotifier3D obj)
        {
            return obj.ObserveSignal<Camera3D>("camera_entered");
        }

        public static IObservable<Unit> OnScreenExited(this VisibleOnScreenNotifier3D obj)
        {
            return obj.ObserveSignal("screen_exited");
        }

        public static IObservable<Unit> OnEditorRefreshRequest(this VisualShaderNode obj)
        {
            return obj.ObserveSignal("editor_refresh_request");
        }

        public static IObservable<Unit> OnInputTypeChanged(this VisualShaderNodeInput obj)
        {
            return obj.ObserveSignal("input_type_changed");
        }

        public static IObservable<Unit> OnFrameChanged(this Sprite2D obj)
        {
            return obj.ObserveSignal("frame_changed");
        }

        public static IObservable<Unit> OnTextureChanged(this Sprite2D obj)
        {
            return obj.ObserveSignal("texture_changed");
        }

        public static IObservable<Unit> OnFrameChanged(this AnimatedSprite2D obj)
        {
            return obj.ObserveSignal("frame_changed");
        }

        public static IObservable<Unit> OnAnimationFinished(this AnimatedSprite2D obj)
        {
            return obj.ObserveSignal("animation_finished");
        }

        public static IObservable<Unit> OnTextureChanged(this MeshInstance2D obj)
        {
            return obj.ObserveSignal("texture_changed");
        }

        public static IObservable<Unit> OnTextureChanged(this MultiMeshInstance2D obj)
        {
            return obj.ObserveSignal("texture_changed");
        }

        public static IObservable<Node> OnBodyEntered(this RigidBody2D obj)
        {
            return obj.ObserveSignal<Node>("body_entered");
        }

        public static IObservable<(int BodyId, Node Body, int BodyShape, int LocalShape)> OnBodyShapeEntered(
            this RigidBody2D obj)
        {
            return obj.ObserveSignal<int, Node, int, int>("body_shape_entered");
        }

        public static IObservable<Unit> OnSleepingStateChanged(this RigidBody2D obj)
        {
            return obj.ObserveSignal("sleeping_state_changed");
        }

        public static IObservable<Node> OnBodyExited(this RigidBody2D obj)
        {
            return obj.ObserveSignal<Node>("body_exited");
        }

        public static IObservable<(int BodyId, Node Body, int BodyShape, int LocalShape)> OnBodyShapeExited(
            this RigidBody2D obj)
        {
            return obj.ObserveSignal<int, Node, int, int>("body_shape_exited");
        }

        public static IObservable<Unit> OnMouseExited(this CollisionObject2D obj)
        {
            return obj.ObserveSignal("mouse_exited");
        }

        public static IObservable<Unit> OnMouseEntered(this CollisionObject2D obj)
        {
            return obj.ObserveSignal("mouse_entered");
        }

        public static IObservable<(Node SubViewport, InputEvent Event, int ShapeIdx)> OnInputEvent(
            this CollisionObject2D obj)
        {
            return obj.ObserveSignal<Node, InputEvent, int>("input_event");
        }

        public static IObservable<Area2D> OnAreaExited(this Area2D obj)
        {
            return obj.ObserveSignal<Area2D>("area_exited");
        }

        public static IObservable<(int AreaId, Area2D Area3D, int AreaShape, int SelfShape)> OnAreaShapeExited(
            this Area2D obj)
        {
            return obj.ObserveSignal<int, Area2D, int, int>("area_shape_exited");
        }

        public static IObservable<Node> OnBodyEntered(this Area2D obj)
        {
            return obj.ObserveSignal<Node>("body_entered");
        }

        public static IObservable<(int BodyId, Node Body, int BodyShape, int AreaShape)> OnBodyShapeEntered(
            this Area2D obj)
        {
            return obj.ObserveSignal<int, Node, int, int>("body_shape_entered");
        }

        public static IObservable<Area2D> OnAreaEntered(this Area2D obj)
        {
            return obj.ObserveSignal<Area2D>("area_entered");
        }

        public static IObservable<(int AreaId, Area2D Area3D, int AreaShape, int SelfShape)> OnAreaShapeEntered(
            this Area2D obj)
        {
            return obj.ObserveSignal<int, Area2D, int, int>("area_shape_entered");
        }

        public static IObservable<Node> OnBodyExited(this Area2D obj)
        {
            return obj.ObserveSignal<Node>("body_exited");
        }

        public static IObservable<(int BodyId, Node Body, int BodyShape, int AreaShape)> OnBodyShapeExited(
            this Area2D obj)
        {
            return obj.ObserveSignal<int, Node, int, int>("body_shape_exited");
        }

        public static IObservable<Unit> OnScreenEntered(this VisibleOnScreenNotifier2D obj)
        {
            return obj.ObserveSignal("screen_entered");
        }

        public static IObservable<SubViewport> OnViewportEntered(this VisibleOnScreenNotifier2D obj)
        {
            return obj.ObserveSignal<SubViewport>("viewport_entered");
        }

        public static IObservable<Unit> OnScreenExited(this VisibleOnScreenNotifier2D obj)
        {
            return obj.ObserveSignal("screen_exited");
        }

        public static IObservable<SubViewport> OnViewportExited(this VisibleOnScreenNotifier2D obj)
        {
            return obj.ObserveSignal<SubViewport>("viewport_exited");
        }

        public static IObservable<Unit> OnBoneSetupChanged(this Skeleton2D obj)
        {
            return obj.ObserveSignal("bone_setup_changed");
        }

        public static IObservable<Unit> OnSettingsChanged(this TileMap obj)
        {
            return obj.ObserveSignal("settings_changed");
        }

        public static IObservable<Unit> OnReleased(this TouchScreenButton obj)
        {
            return obj.ObserveSignal("released");
        }

        public static IObservable<Unit> OnPressed(this TouchScreenButton obj)
        {
            return obj.ObserveSignal("pressed");
        }

        public static IObservable<Unit> OnTracksChanged(this Animation obj)
        {
            return obj.ObserveSignal("tracks_changed");
        }

        public static IObservable<Unit> OnTextureChanged(this StyleBoxTexture obj)
        {
            return obj.ObserveSignal("texture_changed");
        }

        public static IObservable<Unit> OnFinished(this AudioStreamPlayer obj)
        {
            return obj.ObserveSignal("finished");
        }

        public static IObservable<Unit> OnFinished(this AudioStreamPlayer2D obj)
        {
            return obj.ObserveSignal("finished");
        }

        public static IObservable<Unit> OnFinished(this AudioStreamPlayer3D obj)
        {
            return obj.ObserveSignal("finished");
        }

        public static IObservable<Unit> OnConnectedToServer(this SceneTree obj)
        {
            return obj.ObserveSignal("connected_to_server");
        }

        public static IObservable<Node> OnNodeConfigurationWarningChanged(this SceneTree obj)
        {
            return obj.ObserveSignal<Node>("node_configuration_warning_changed");
        }

        public static IObservable<Unit> OnConnectionFailed(this SceneTree obj)
        {
            return obj.ObserveSignal("connection_failed");
        }

        public static IObservable<Unit> OnPhysicsFrame(this SceneTree obj)
        {
            return obj.ObserveSignal("physics_frame");
        }

        public static IObservable<Unit> OnScreenResized(this SceneTree obj)
        {
            return obj.ObserveSignal("screen_resized");
        }

        public static IObservable<int> OnNetworkPeerDisconnected(this SceneTree obj)
        {
            return obj.ObserveSignal<int>("network_peer_disconnected");
        }

        public static IObservable<int> OnNetworkPeerConnected(this SceneTree obj)
        {
            return obj.ObserveSignal<int>("network_peer_connected");
        }

        public static IObservable<Node> OnNodeRemoved(this SceneTree obj)
        {
            return obj.ObserveSignal<Node>("node_removed");
        }

        public static IObservable<Node> OnNodeAdded(this SceneTree obj)
        {
            return obj.ObserveSignal<Node>("node_added");
        }

        public static IObservable<(string[] Files, int Screen)> OnFilesDropped(this SceneTree obj)
        {
            return obj.ObserveSignal<string[], int>("files_dropped");
        }

        public static IObservable<Unit> OnIdleFrame(this SceneTree obj)
        {
            return obj.ObserveSignal("idle_frame");
        }

        public static IObservable<Unit> OnServerDisconnected(this SceneTree obj)
        {
            return obj.ObserveSignal("server_disconnected");
        }

        public static IObservable<Node> OnNodeRenamed(this SceneTree obj)
        {
            return obj.ObserveSignal<Node>("node_renamed");
        }

        public static IObservable<Unit> OnTreeChanged(this SceneTree obj)
        {
            return obj.ObserveSignal("tree_changed");
        }

        public static IObservable<(object Id, object Meta)> OnGlobalMenuAction(this SceneTree obj)
        {
            return obj.ObserveSignal<object, object>("global_menu_action");
        }

        public static IObservable<Unit> OnTimeout(this SceneTreeTimer obj)
        {
            return obj.ObserveSignal("timeout");
        }

        public static IObservable<string> OnMainScreenChanged(this EditorPlugin obj)
        {
            return obj.ObserveSignal<string>("main_screen_changed");
        }

        public static IObservable<string> OnSceneClosed(this EditorPlugin obj)
        {
            return obj.ObserveSignal<string>("scene_closed");
        }

        public static IObservable<Node> OnSceneChanged(this EditorPlugin obj)
        {
            return obj.ObserveSignal<Node>("scene_changed");
        }

        public static IObservable<Resource> OnResourceSaved(this EditorPlugin obj)
        {
            return obj.ObserveSignal<Resource>("resource_saved");
        }

        public static IObservable<Unit> OnSelectionChanged(this EditorSelection obj)
        {
            return obj.ObserveSignal("selection_changed");
        }

        public static IObservable<string[]> OnFilesSelected(this EditorFileDialog obj)
        {
            return obj.ObserveSignal<string[]>("files_selected");
        }

        public static IObservable<string> OnDirSelected(this EditorFileDialog obj)
        {
            return obj.ObserveSignal<string>("dir_selected");
        }

        public static IObservable<string> OnFileSelected(this EditorFileDialog obj)
        {
            return obj.ObserveSignal<string>("file_selected");
        }

        public static IObservable<string[]> OnResourcesReimported(this EditorFileSystem obj)
        {
            return obj.ObserveSignal<string[]>("resources_reimported");
        }

        public static IObservable<bool> OnSourcesChanged(this EditorFileSystem obj)
        {
            return obj.ObserveSignal<bool>("sources_changed");
        }

        public static IObservable<Unit> OnFilesystemChanged(this EditorFileSystem obj)
        {
            return obj.ObserveSignal("filesystem_changed");
        }

        public static IObservable<string[]> OnResourcesReload(this EditorFileSystem obj)
        {
            return obj.ObserveSignal<string[]>("resources_reload");
        }

        public static IObservable<Unit> OnSettingsChanged(this EditorSettings obj)
        {
            return obj.ObserveSignal("settings_changed");
        }

        public static IObservable<string> OnPreviewInvalidated(this EditorResourcePreview obj)
        {
            return obj.ObserveSignal<string>("preview_invalidated");
        }

        public static IObservable<Script> OnEditorScriptChanged(this ScriptEditor obj)
        {
            return obj.ObserveSignal<Script>("editor_script_changed");
        }

        public static IObservable<Script> OnScriptClose(this ScriptEditor obj)
        {
            return obj.ObserveSignal<Script>("script_close");
        }

        public static IObservable<string> OnPropertyEdited(this EditorInspector obj)
        {
            return obj.ObserveSignal<string>("property_edited");
        }

        public static IObservable<int> OnObjectIdSelected(this EditorInspector obj)
        {
            return obj.ObserveSignal<int>("object_id_selected");
        }

        public static IObservable<string> OnPropertySelected(this EditorInspector obj)
        {
            return obj.ObserveSignal<string>("property_selected");
        }

        public static IObservable<Unit> OnRestartRequested(this EditorInspector obj)
        {
            return obj.ObserveSignal("restart_requested");
        }

        public static IObservable<string> OnPropertyKeyed(this EditorInspector obj)
        {
            return obj.ObserveSignal<string>("property_keyed");
        }

        public static IObservable<(GodotObject Res, string Prop)> OnResourceSelected(this EditorInspector obj)
        {
            return obj.ObserveSignal<GodotObject, string>("resource_selected");
        }

        public static IObservable<(string Property, bool Checked)> OnPropertyToggled(this EditorInspector obj)
        {
            return obj.ObserveSignal<string, bool>("property_toggled");
        }

        public static IObservable<(string Property, int Id)> OnObjectIdSelected(this EditorProperty obj)
        {
            return obj.ObserveSignal<string, int>("object_id_selected");
        }

        public static IObservable<(string Property, string Bool)> OnPropertyChecked(this EditorProperty obj)
        {
            return obj.ObserveSignal<string, string>("property_checked");
        }

        public static IObservable<(string Property, object Value)> OnPropertyKeyedWithValue(this EditorProperty obj)
        {
            return obj.ObserveSignal<string, object>("property_keyed_with_value");
        }

        public static IObservable<string> OnPropertyKeyed(this EditorProperty obj)
        {
            return obj.ObserveSignal<string>("property_keyed");
        }

        public static IObservable<(string Property, object Value)> OnPropertyChanged(this EditorProperty obj)
        {
            return obj.ObserveSignal<string, object>("property_changed");
        }

        public static IObservable<(string Path3D, Resource Resource)> OnResourceSelected(this EditorProperty obj)
        {
            return obj.ObserveSignal<string, Resource>("resource_selected");
        }

        public static IObservable<(string Path3D, int FocusableIdx)> OnSelected(this EditorProperty obj)
        {
            return obj.ObserveSignal<string, int>("selected");
        }

        public static IObservable<(string[] Properties, Array Value)> OnMultiplePropertiesChanged(
            this EditorProperty obj)
        {
            return obj.ObserveSignal<string[], Array>("multiple_properties_changed");
        }

        public static IObservable<Script> OnScriptCreated(this ScriptCreateDialog obj)
        {
            return obj.ObserveSignal<Script>("script_created");
        }

        public static IObservable<Unit> OnDisplayModeChanged(this FileSystemDock obj)
        {
            return obj.ObserveSignal("display_mode_changed");
        }

        public static IObservable<string> OnInherit(this FileSystemDock obj)
        {
            return obj.ObserveSignal<string>("inherit");
        }

        public static IObservable<(string OldFile, string NewFile)> OnFilesMoved(this FileSystemDock obj)
        {
            return obj.ObserveSignal<string, string>("files_moved");
        }

        public static IObservable<string> OnFolderRemoved(this FileSystemDock obj)
        {
            return obj.ObserveSignal<string>("folder_removed");
        }

        public static IObservable<string[]> OnInstance(this FileSystemDock obj)
        {
            return obj.ObserveSignal<string[]>("instance");
        }

        public static IObservable<(string OldFolder, string NewFile)> OnFolderMoved(this FileSystemDock obj)
        {
            return obj.ObserveSignal<string, string>("folder_moved");
        }

        public static IObservable<string> OnFileRemoved(this FileSystemDock obj)
        {
            return obj.ObserveSignal<string>("file_removed");
        }

        public static IObservable<object> OnCompleted(this GDScript obj)
        {
            return obj.ObserveSignal<object>("completed");
        }

        public static IObservable<Vector3> OnCellSizeChanged(this GridMap obj)
        {
            return obj.ObserveSignal<Vector3>("cell_size_changed");
        }


        public static IObservable<int> OnPeerPacket(this WebSocketMultiplayerPeer obj)
        {
            return obj.ObserveSignal<int>("peer_packet");
        }
    }

    public static class VisualServerSignals
    {
        public static IObservable<Unit> OnFramePostDraw()
        {
            return RenderingServer.Singleton.ObserveSignal("frame_post_draw");
        }

        public static IObservable<Unit> OnFramePreDraw()
        {
            return RenderingServer.Singleton.ObserveSignal("frame_pre_draw");
        }
    }

    public static class InputSignals
    {
        public static IObservable<(int Device, bool Connected)> OnJoyConnectionChanged()
        {
            return Input.Singleton.ObserveSignal<int, bool>("joy_connection_changed");
        }
    }

    public static class AudioServerSignals
    {
        public static IObservable<Unit> OnBusLayoutChanged()
        {
            return AudioServer.Singleton.ObserveSignal("bus_layout_changed");
        }
    }

    public static class ARVRServerSignals
    {
        public static IObservable<(string TrackerName, int Type, int Id)> OnTrackerRemoved()
        {
            return XRServer.Singleton.ObserveSignal<string, int, int>("tracker_removed");
        }

        public static IObservable<(string TrackerName, int Type, int Id)> OnTrackerAdded()
        {
            return XRServer.Singleton.ObserveSignal<string, int, int>("tracker_added");
        }

        public static IObservable<string> OnInterfaceRemoved()
        {
            return XRServer.Singleton.ObserveSignal<string>("interface_removed");
        }

        public static IObservable<string> OnInterfaceAdded()
        {
            return XRServer.Singleton.ObserveSignal<string>("interface_added");
        }
    }

    public static class CameraServerSignals
    {
        public static IObservable<int> OnCameraFeedRemoved()
        {
            return CameraServer.Singleton.ObserveSignal<int>("camera_feed_removed");
        }

        public static IObservable<int> OnCameraFeedAdded()
        {
            return CameraServer.Singleton.ObserveSignal<int>("camera_feed_added");
        }
    }
}